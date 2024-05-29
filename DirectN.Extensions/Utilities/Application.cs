namespace DirectN.Utilities;

[SupportedOSPlatform("windows6.0.6000")]
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

    private bool _disposedValue;

    public Application()
    {
        if (Interlocked.CompareExchange(ref _current, this, null) != null)
            throw new DirectNException("0003: There can be only one Application instance.");

        UIhreadId = Environment.CurrentManagedThreadId;
    }

    public virtual void Run()
    {
        if (_errors.IsEmpty)
        {
            while (Functions.GetMessageW(out var msg, HWND.Null, 0, 0))
            {
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
        //Trace("windows count:" + _windows.Count);
        if (!_disposedValue)
        {
            if (disposing)
            {
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
            }

            // free unmanaged resources (unmanaged objects) and override finalizer
            // set large fields to null
            _disposedValue = true;
        }
    }

    ~Application() { Dispose(disposing: false); }
    public void Dispose() { Dispose(disposing: true); GC.SuppressFinalize(this); }

    internal static void AddWindow(Window window)
    {
        //Trace("window:" + window);
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
        //Trace("window:" + window);
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

        var ts = error.ToString();
        if (_errors.Any(e => e.ToString() == ts))
            return;

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

        //Trace("Hwnd:" + hwnd.Value + Environment.NewLine + string.Join(Environment.NewLine, _errors));
        var errors = _errors.ToArray();
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

    public static void Trace(object? message, [CallerMemberName] string? methodName = null)
    {
        if (!string.IsNullOrEmpty(methodName))
        {
            methodName += "|";
        }

        var name = Thread.CurrentThread.Name.Nullify() ?? Environment.CurrentManagedThreadId.ToString();
        EventProvider.Default.WriteMessageEvent(name + "|" + methodName + message);
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
