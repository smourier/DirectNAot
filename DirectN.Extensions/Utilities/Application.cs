namespace DirectN.Extensions.Utilities;

public class Application : IDisposable
{
    private static Application? _current;
    private static bool _exiting;
    private static ConcurrentDictionary<Window, object?> _windows = [];
    private readonly static ConcurrentQueue<Error> _errors = [];
    internal const uint WM_APP_QUIT = MessageDecoder.WM_APP + 0x3FFF; // last possible app message

    public static event EventHandler<ValueEventArgs<Window>>? WindowRemoved;
    public static event EventHandler<ValueEventArgs<Window>>? WindowAdded;
    public static event EventHandler? ApplicationExit;
    public static event EventHandler<CancelEventArgs>? ShowingFatalError;

    static Application()
    {
        AppDomain.CurrentDomain.UnhandledException += OnCurrentDomainUnhandledException;
    }

    private static void OnCurrentDomainUnhandledException(object sender, UnhandledExceptionEventArgs e)
    {
        if (e.ExceptionObject is Exception error)
        {
            AddError(error);
            var e2 = new CancelEventArgs();
            ShowingFatalError?.Invoke(Current, e2);
            if (e2.Cancel)
                return;

            if (CanShowFatalError)
            {
                var handle = _windows.FirstOrDefault(w => !w.Key.IsBackground && w.Key.IsWindow).Key?.Handle;
                if (handle == null)
                {
                    handle = _windows.FirstOrDefault(w => w.Key.IsBackground && w.Key.IsWindow).Key?.Handle;
                }
                ShowFatalError(handle ?? HWND.Null);
            }
        }
    }

    private int _disposeState;

    public Application()
    {
        if (Interlocked.CompareExchange(ref _current, this, null) != null)
            throw new DirectNException("0003: There can be only one Application instance.");

        UIhreadId = Environment.CurrentManagedThreadId;
    }

    public bool IsDisposingOrDisposed => _disposeState != 0;
    public bool IsDisposing => _disposeState == 1;
    public bool IsDisposed => _disposeState == 2;

    public virtual void Run()
    {
        if (_errors.IsEmpty)
        {
            while (Functions.GetMessageW(out var msg, HWND.Null, 0, 0))
            {
                if (IsDisposingOrDisposed)
                    break;

                if (msg.message == WM_APP_QUIT)
                    break;

                Functions.TranslateMessage(msg);
                Functions.DispatchMessageW(msg);
            }
        }

        if (CanShowFatalError)
        {
            ShowFatalError(HWND.Null);
        }
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!disposing)
            return;

        //TraceInfo("windows count:" + _windows.Count);
        var isDisposing = Interlocked.CompareExchange(ref _disposeState, 1, 0);
        if (isDisposing != 0)
            return;

        // dispose managed state (managed objects)
        var windows = Interlocked.Exchange(ref _windows, new());
        foreach (var kv in windows)
        {
            WindowRemoved?.Invoke(Current, new ValueEventArgs<Window>(kv.Key));
            kv.Key.Dispose();
        }

        if (ReportLiveObjects)
        {
            DXGIFunctions.DXGIReportLiveObjects();
        }

        Interlocked.Exchange(ref _disposeState, 2);
    }

    ~Application() { Dispose(disposing: false); }
    public void Dispose() { Dispose(disposing: true); GC.SuppressFinalize(this); }

    internal static void AddWindow(Window window)
    {
        //TraceInfo("window:" + window);
        if (_windows.TryAdd(window, null))
        {
            // default is for new windows to be background (don't prevent to quit)
            if (_windows.Count > 1)
            {
                window.IsBackground = true;
            }

            WindowAdded?.Invoke(Current, new ValueEventArgs<Window>(window));
        }
    }

    internal static void RemoveWindow(Window window)
    {
        //TraceInfo("window:" + window);
        if (!_windows.TryRemove(window, out _))
            return;

        WindowRemoved?.Invoke(Current, new ValueEventArgs<Window>(window));
        if (QuitOnLastWindowRemoved && !_exiting && !_windows.Any(w => !w.Key.IsBackground))
        {
            _exiting = true;
            foreach (var bw in _windows.ToArray().Where(w => w.Key.IsBackground))
            {
                bw.Key?.Dispose();
            }
            Exit();
        }
    }

    public static Application Current
    {
        get
        {
            if (_current == null)
            {
                _ = new Application();
            }
            return _current!;
        }
    }

    public static IEnumerable<Window> Windows => _windows.Keys;
    public static HMODULE ModuleHandle => Functions.GetModuleHandleW(PWSTR.Null);
    public static bool IsFatalErrorShowing { get; private set; }
    public static bool QuitOnLastWindowRemoved { get; set; } = true;
    public static bool CanShowFatalError { get; set; } = true;
    public static int MaximumNumberOfErrors { get; set; } = 3;
    public static TraceLevel TraceLevel { get; set; } = TraceLevel.Verbose;
    public static int UIhreadId { get; private set; }
    public static bool ReportLiveObjects { get; set; }
#if DEBUG
        = true;
#endif
    public static bool IsRunningAsUIThread => UIhreadId == Environment.CurrentManagedThreadId;
    public static void ThrowIfNotRunningAsUIThread() { if (!IsRunningAsUIThread) throw new DirectNException("0002: This method must be called on the render thread."); }

    public static void Exit()
    {
        ApplicationExit?.Invoke(Current, EventArgs.Empty);
        Functions.PostQuitMessage(0);
    }

    public static bool HasErrors => !_errors.IsEmpty;
    public static void AddError(Exception? error, [CallerMemberName] string? methodName = null)
    {
        if (error == null)
            return;

        TraceError(error);
        var ts = error.ToString();
        if (_errors.Any(e => e.ToString() == ts))
            return;

        while (_errors.Count >= MaximumNumberOfErrors)
        {
            _errors.TryDequeue(out _);
        }

        _errors.Enqueue(new(error, methodName));

        // we don't use PostQuitMessage because it prevents any other windows from showing (like messagebox, taskdialog, etc.)
        Functions.PostMessageW(HWND.Null, WM_APP_QUIT, WPARAM.Null, LPARAM.Null);
    }

    public static MESSAGEBOX_RESULT ShowFatalError(HWND hwnd, bool clearErrors = true)
    {
        if (_errors.IsEmpty)
            return 0;

        if (IsFatalErrorShowing)
            return 0;

        TraceError("Hwnd:" + hwnd.Value.ToHex() + Environment.NewLine + string.Join(Environment.NewLine, _errors));
        var errors = _errors.ToArray();
        if (errors.Length == 0)
            return 0;

        var windows = _windows.ToArray();
        foreach (var kv in windows)
        {
            if (!kv.Key.ShowingFatalError())
                return 0;
        }

        IsFatalErrorShowing = true;
        try
        {
            var td = new TaskDialog();
            td.Flags |= TASKDIALOG_FLAGS.TDF_SIZE_TO_CONTENT;
            td.MainIcon = new HICON { Value = TaskDialog.TD_ERROR_ICON };
            td.Title = GetTitle(hwnd);
            if (errors.Length == 1)
            {
                td.MainInstruction = "A fatal error has occured. Press OK to quit.";
                td.Content = errors[0].ToString();
            }
            else
            {
                td.MainInstruction = errors.Length + " fatal errors have occured. Press OK to quit.";
                var i = 1;
                var sb = new StringBuilder();
                foreach (var error in errors)
                {
                    if (i > 0)
                    {
                        sb.AppendLine();
                        sb.AppendLine();
                    }

                    sb.AppendLine("Error #" + i);
                    i++;

                    sb.Append(error);
                }
                td.Content = sb.ToString();
            }

            var res = td.Show(hwnd);
            if (clearErrors)
            {
                _errors.Clear();
            }
            return res;
        }
        finally
        {
            IsFatalErrorShowing = false;
        }
    }

    public static string GetTitle() => GetTitle(HWND.Null);
    public static string GetTitle(HWND hwnd)
    {
        string? text;
        if (hwnd.Value != 0)
        {
            using var p = new AllocPwstr(1024 * 2);
            Functions.GetWindowTextW(hwnd, p, (int)p.SizeInChars);
            text = p.ToString().Nullify();
            if (text != null)
                return text;
        }

        text = Assembly.GetEntryAssembly().GetTitle().Nullify();
        if (text != null)
            return text;

        text = Assembly.GetEntryAssembly().GetProduct().Nullify();
        if (text != null)
            return text;

        return Assembly.GetEntryAssembly()?.GetName().Name ?? "DirectN Application";
    }

    protected virtual internal bool TraceMessage(uint msg)
    {
        return false;
        //#if DEBUG
        //        // remove super verbose messages
        //        return msg != MessageDecoder.WM_SETCURSOR && msg != MessageDecoder.WM_NCMOUSEMOVE && msg != MessageDecoder.WM_MOUSEMOVE &&
        //            msg != MessageDecoder.WM_NCHITTEST && msg != MessageDecoder.WM_ERASEBKGND && msg != MessageDecoder.WM_PAINT && msg != MessageDecoder.WM_GETICON;
        //#else
        //        return false;
        //#endif
    }

    public static void TraceInfo(object? message = null, [CallerMemberName] string? methodName = null) => Trace(TraceLevel.Info, message, methodName);
    public static void TraceWarning(object? message = null, [CallerMemberName] string? methodName = null) => Trace(TraceLevel.Warning, message, methodName);
    public static void TraceVerbose(object? message = null, [CallerMemberName] string? methodName = null) => Trace(TraceLevel.Verbose, message, methodName);
    public static void TraceError(object? message = null, [CallerMemberName] string? methodName = null) => Trace(TraceLevel.Error, message, methodName);
    public static void Trace(TraceLevel level, object? message = null, [CallerMemberName] string? methodName = null)
    {
        if (level > TraceLevel)
            return;

        if (!string.IsNullOrEmpty(methodName))
        {
            methodName += "|";
        }

        string? slevel = null;
        if (level == TraceLevel.Warning || level == TraceLevel.Error)
        {
            slevel = level.ToString() + "|";
        }

        var name = Thread.CurrentThread.Name.Nullify() ?? Environment.CurrentManagedThreadId.ToString();
        EventProvider.Default.WriteMessageEvent(name + "|" + methodName + slevel + message, (byte)level);
    }

    private sealed class Error(Exception exception, string? methodName)
    {
        public Exception Exception => exception;
        public string? MethodName => methodName;

        public override string ToString()
        {
            if (!string.IsNullOrWhiteSpace(MethodName))
                return $"{MethodName} {Exception}";

            return Exception.ToString();
        }
    }
}
