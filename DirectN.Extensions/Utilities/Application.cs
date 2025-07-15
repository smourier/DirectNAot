namespace DirectN.Extensions.Utilities;

public class Application : IDisposable
{
    public event EventHandler? ApplicationExit;
    private bool _disposedValue;

    public Application()
    {
        var apps = _applications;
        if (apps == null)
            throw new DirectNException("0003: It's not possible to create applications any more.");

        apps.AddOrUpdate(Environment.CurrentManagedThreadId, this, (k, o) =>
        {
            throw new DirectNException("0006: There can be only one Application instance for a given thread.");
        });

        UIThreadId = Environment.CurrentManagedThreadId;
        ThreadId = Functions.GetCurrentThreadId();
    }

    public bool ExitOnLastWindowRemoved { get; set; } = true;
    public bool Exiting { get; private set; }
    public int UIThreadId { get; private set; }
    public uint ThreadId { get; }
    public bool IsRunningAsUIThread => UIThreadId == Environment.CurrentManagedThreadId;
    public bool IsDisposed => _disposedValue;

    public IReadOnlyList<Window> Windows
    {
        get
        {
            lock (_windowsLock)
            {
                return [.. _windows.Where(w => w.ManagedThreadId == UIThreadId)];
            }
        }
    }

    public IReadOnlyList<Window> BackgroundWindows
    {
        get
        {
            lock (_windowsLock)
            {
                return [.. _windows.Where(w => w.ManagedThreadId == UIThreadId && w.IsBackground)];
            }
        }
    }

    public IReadOnlyList<Window> NonBackgroundWindows
    {
        get
        {
            lock (_windowsLock)
            {
                return [.. _windows.Where(w => w.ManagedThreadId == UIThreadId && !w.IsBackground)];
            }
        }
    }

    public void ThrowIfNotRunningAsUIThread() { if (!IsRunningAsUIThread) throw new DirectNException("0002: This method must be called on the render thread."); }

    public virtual ExitLoopReason Run()
    {
        var reason = ExitLoopReason.Quit;
        if (!HasErrors)
        {
            while (Functions.GetMessageW(out var msg, HWND.Null, 0, 0))
            {
                if (IsDisposed)
                {
                    reason = ExitLoopReason.Disposed;
                    break;
                }

                if (msg.message == WM_APP_QUIT)
                {
                    reason = ExitLoopReason.AppQuit;
                    break;
                }

                if (!HandleMessage(msg))
                {
                    reason = ExitLoopReason.UnhandledMessage;
                    break;
                }
            }
        }

        if (CanShowFatalError)
        {
            ShowFatalError(HWND.Null);
        }
        return reason;
    }

    public virtual ExitLoopReason RunMessageLoop(Func<MSG, bool> exitLoopFunc)
    {
        ArgumentNullException.ThrowIfNull(exitLoopFunc);
        ThrowIfNotRunningAsUIThread();
        do
        {
            if (Functions.PeekMessageW(out var msg, HWND.Null, 0, 0, PEEK_MESSAGE_REMOVE_TYPE.PM_REMOVE))
            {
                if (exitLoopFunc(msg))
                    return ExitLoopReason.Func;

                if (IsDisposed)
                {
                    // repost
                    Functions.PostMessageW(HWND.Null, WM_APP_QUIT, WPARAM.Null, LPARAM.Null);
                    return ExitLoopReason.Disposed;
                }

                if (msg.message == MessageDecoder.WM_QUIT)
                {
                    // repost
                    Functions.PostQuitMessage(0);
                    return ExitLoopReason.Quit;
                }

                if (msg.message == WM_APP_QUIT)
                {
                    // repost
                    Functions.PostMessageW(HWND.Null, WM_APP_QUIT, WPARAM.Null, LPARAM.Null);
                    return ExitLoopReason.AppQuit;
                }

                if (!HandleMessage(msg))
                    return ExitLoopReason.UnhandledMessage;
            }
        } while (true);
    }

    protected virtual bool HandleMessage(in MSG msg)
    {
        Functions.TranslateMessage(msg);
        Functions.DispatchMessageW(msg);
        return true;
    }

    protected virtual void OnApplicationExit(object sender, EventArgs e) => ApplicationExit?.Invoke(sender, e);
    public virtual void Exit()
    {
        ThrowIfNotRunningAsUIThread();
        OnApplicationExit(this, EventArgs.Empty);
        Functions.PostQuitMessage(0);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!disposing)
            return;

        if (!_disposedValue)
        {
            // note: we don't check thread id here
            _applications?.TryRemove(Environment.CurrentManagedThreadId, out _);
            OnApplicationExit(this, EventArgs.Empty);
            _disposedValue = true;
        }

        if (ReportLiveObjects)
        {
            DXGIFunctions.DXGIReportLiveObjects();
        }
    }

    public void Dispose() { Dispose(disposing: true); GC.SuppressFinalize(this); }

    internal const uint WM_APP_QUIT = MessageDecoder.WM_APP + 0x3FFF; // last possible app message
    private static readonly Lock _windowsLock = new();
    private static readonly Lock _errorsLock = new();
    private readonly static List<Window> _windows = [];
    private readonly static List<Exception> _errors = [];
    private static ConcurrentDictionary<int, Application>? _applications = [];

    public static event EventHandler<ValueEventArgs<Window>>? WindowRemoved;
    public static event EventHandler<ValueEventArgs<Window>>? WindowAdded;
    public static event EventHandler? AllApplicationsExit;
    public static event EventHandler<CancelEventArgs>? ShowingFatalError;

    static Application()
    {
        AppDomain.CurrentDomain.UnhandledException += OnCurrentDomainUnhandledException;
    }

    public static Application? Current
    {
        get
        {
            var apps = _applications;
            if (apps == null)
                return null;

            apps.TryGetValue(Environment.CurrentManagedThreadId, out var app);
            return app;
        }
    }

    public static IReadOnlyList<Window> AllWindows
    {
        get
        {
            lock (_windowsLock)
            {
                return [.. _windows];
            }
        }
    }

    public static IReadOnlyDictionary<int, Application> Applications => _applications ?? [];
    public static bool HasErrors => _errors.Count > 0;
    public static Exception[] Errors { get { lock (_errorsLock) { return [.. _errors]; } } }
    public static HMODULE ModuleHandle => Functions.GetModuleHandleW(PWSTR.Null);
    public static bool IsFatalErrorShowing { get; private set; }
    public static bool CanShowFatalError { get; set; } = true;
    public static bool ExitAllOnLastWindowRemoved { get; set; } = true;
    public static bool AllExiting { get; private set; }
    public static int MaximumNumberOfErrors { get; set; } = 3;
    public static TraceLevel TraceLevel { get; set; } = TraceLevel.Verbose;
    public static bool ReportLiveObjects { get; set; }
#if DEBUG
        = true;
#endif

    public static Application? GetApplication(Window? window) => GetApplication(window?.ManagedThreadId ?? 0);
    public static Application? GetApplication(int threadId)
    {
        if (threadId == 0)
            return null;

        var apps = _applications;
        if (apps == null)
            return null;

        apps.TryGetValue(threadId, out var app);
        return app;
    }

    public static void AllExit()
    {
        var apps = Interlocked.Exchange(ref _applications, null);
        if (apps == null)
            return;

        foreach (var kv in apps)
        {
            // call from one thread
            kv.Value.OnApplicationExit(kv.Value, EventArgs.Empty);
            Functions.PostThreadMessageW(kv.Value.ThreadId, MessageDecoder.WM_QUIT, IntPtr.Zero, IntPtr.Zero);
        }

        AllApplicationsExit?.Invoke(null, EventArgs.Empty);
    }

    public static void AddError(Exception? error, [CallerMemberName] string? methodName = null)
    {
        if (error == null)
            return;

        lock (_errorsLock)
        {
            TraceError(error);
            var ts = error.ToString();
            if (_errors.Any(e => e.ToString() == ts))
                return;

            if (_errors.Count >= MaximumNumberOfErrors)
                return;

            TraceError(error, methodName);
            _errors.Add(error);
        }

        // we don't use PostQuitMessage because it prevents any other windows from showing (like messagebox, taskdialog, etc.)
        Functions.PostMessageW(HWND.Null, WM_APP_QUIT, WPARAM.Null, LPARAM.Null);
    }

    public static MESSAGEBOX_RESULT ShowFatalError(HWND hwnd, bool clearErrors = true)
    {
        if (!HasErrors)
            return 0;

        if (IsFatalErrorShowing)
            return 0;

        TraceError("Hwnd:" + hwnd.Value.ToHex() + Environment.NewLine + string.Join(Environment.NewLine, _errors));
        var errors = _errors.ToArray();
        if (errors.Length == 0)
            return 0;

        var windows = AllWindows;
        foreach (var win in windows)
        {
            if (!win.ShowingFatalError())
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

    public unsafe static bool InitCommonControlsEx(INITCOMMONCONTROLSEX_ICC flags = 0, bool throwOnError = true)
    {
        if (flags == 0)
        {
            foreach (var value in Enum.GetValues<INITCOMMONCONTROLSEX_ICC>())
            {
                flags |= value;
            }
        }

        var init = new INITCOMMONCONTROLSEX { dwSize = (uint)sizeof(INITCOMMONCONTROLSEX), dwICC = flags, };
        var ret = Functions.InitCommonControlsEx(init);
        if (!ret && throwOnError)
            throw new Win32Exception(Marshal.GetLastPInvokeError());

        return ret;
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
                AddError(error);
                var win = _windows.FirstOrDefault()?.Handle;
                ShowFatalError(win.GetValueOrDefault());
            }
        }
    }

    internal static void AddWindow(Window window)
    {
        lock (_windowsLock)
        {
            _windows.Add(window);

            var apps = _applications;
            if (apps != null)
            {
                apps.TryGetValue(window.ManagedThreadId, out var app);
                if (app != null)
                {
                    // default is for new windows to be background (don't prevent to quit)
                    if (app.Windows.Count > 1)
                    {
                        window.IsBackground = true;
                    }

                    WindowAdded?.Invoke(app, new ValueEventArgs<Window>(window));
                }
            }
        }
    }

    internal static void RemoveWindow(Window window)
    {
        lock (_windowsLock)
        {
            _windows.Remove(window);

            var apps = _applications;
            if (apps != null)
            {
                apps.TryGetValue(window.ManagedThreadId, out var app);
                if (app != null)
                {
                    WindowRemoved?.Invoke(app, new ValueEventArgs<Window>(window));
                    if (app.ExitOnLastWindowRemoved && !app.Exiting && app.NonBackgroundWindows.Count == 0)
                    {
                        app.Exiting = true;
                        foreach (var bw in app.BackgroundWindows)
                        {
                            bw.Dispose();
                        }
                        app.Exit();
                    }
                }
            }

            if (ExitAllOnLastWindowRemoved && !AllExiting && !_windows.Any(w => !w.IsBackground))
            {
                AllExiting = true;
                var backgroundWindows = _windows.Where(w => w.IsBackground).ToArray();
                foreach (var bw in backgroundWindows)
                {
                    bw.Dispose();
                }
                AllExit();
            }
        }
    }
}
