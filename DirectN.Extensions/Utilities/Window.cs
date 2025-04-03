namespace DirectN.Extensions.Utilities;

[SupportedOSPlatform("windows6.0.6000")]
public class Window : IDisposable, IEquatable<Window>
{
    private const uint WM_PROCESS_TASKS = Application.WM_APP_QUIT - 3;
    private const uint WM_WINDOW_CREATED = Application.WM_APP_QUIT - 2;
    private nint _handle;
    private int _disposeState;
    private GCHandle _gcHandle;
    private readonly WNDPROC? _windowProc;
    private ConcurrentQueue<Task>? _tasks = [];
    private readonly Lazy<Process?> _process;
    private readonly Scheduler? _scheduler;

    public event EventHandler? HandleCreated;
    public event EventHandler? Created;
    public event EventHandler? Destroyed;
    public event CancelEventHandler? Disposing;
    public event EventHandler<HandledEventArgs>? Moved;
    public event EventHandler<ValueEventArgs<(WindowResizedType ResizedType, SIZE Size)>>? Resized;
    public event EventHandler<HandledEventArgs>? Activated;
    public event EventHandler<HandledEventArgs>? Deactivated;
    public event EventHandler<HandledEventArgs>? FocusChanged;
    public event EventHandler<CancelEventArgs>? Closing;

    protected Window(nint handle)
    {
        _handle = handle;
        DestroyOnDispose = false;
        _process = new Lazy<Process?>(GetProcess);
    }

    public Window(
        string? title = null,
        WINDOW_STYLE style = WINDOW_STYLE.WS_POPUP | WINDOW_STYLE.WS_THICKFRAME | WINDOW_STYLE.WS_CAPTION | WINDOW_STYLE.WS_SYSMENU | WINDOW_STYLE.WS_MAXIMIZEBOX | WINDOW_STYLE.WS_MINIMIZEBOX,
        WINDOW_EX_STYLE extendedStyle = 0,
        RECT? rect = null,
        HWND? parentHandle = null,
        HMENU? menu = null,
        string? className = null
        )
    {
        className ??= GetType().FullName + AssemblyUtilities.GetInformationalVersion();
        ArgumentNullException.ThrowIfNull(className);
        _process = new Lazy<Process?>(GetProcess);
        _windowProc = SafeWindowProc;
        _scheduler = new Scheduler(this);
        RegisterClass(className, Marshal.GetFunctionPointerForDelegate(_windowProc), LoadCreationIcon());
        CreateWindow(title, style, extendedStyle, rect, parentHandle, menu, className);
        Application.AddWindow(this);
    }

    public HWND Handle => new() { Value = _handle };
    public TaskScheduler? TaskScheduler => _scheduler;
    public Process? Process => _process.Value;
    public bool IsDisposingOrDisposed => _disposeState != 0;
    public bool IsDisposing => _disposeState == 1;
    public bool IsDisposed => _disposeState == 2;
    public virtual bool IsBackground { get; set; } // true => doesn't prevent to quit
    public uint UInt32Handle => (uint)(long)Handle.Value;
    protected virtual uint AboutSysMenuId { get; set; } = 1;
    protected virtual bool ValidateOnPaint { get; set; } = true;
    protected virtual bool DestroyOnDispose { get; set; } = true;
    public D2D_SIZE_U Dpi => DpiUtilities.GetDpiForWindow(Handle);
    public bool IsWindow => Functions.IsWindow(Handle);
    public bool IsEnabled => Functions.IsWindowEnabled(Handle);
    public bool IsForeground => Handle == Functions.GetForegroundWindow();
    public bool IsActive => Handle == Functions.GetActiveWindow();
    public bool IsVisible => Functions.IsWindowVisible(Handle);
    public bool IsZoomed => Functions.IsZoomed(Handle);
    public bool IsHungApp => Functions.IsHungAppWindow(Handle);
    public bool IsIconic => Functions.IsIconic(Handle);
    public bool IsTopLevel => Functions.IsTopLevelWindow(Handle);
    public bool IsDialog => RealClassName == "#32770";
    public bool IsMenu => RealClassName == "#32768";
    public bool HasFocus => Handle == Functions.GetFocus();
    public int ThreadId => (int)Functions.GetWindowThreadProcessId(Handle, 0);
    public unsafe int ProcessId { get { int processId; _ = Functions.GetWindowThreadProcessId(Handle, (nint)(&processId)); return processId; } }
    public Window? Parent => FromHandle(ParentHandle.Value);
    public HWND OwnerHandle => Functions.GetWindow(Handle, GET_WINDOW_CMD.GW_OWNER);
    public Window? Owner => FromHandle(OwnerHandle.Value);
    public RECT ClientRect { get { Functions.GetClientRect(Handle, out var rc); return rc; } }
    public DPI_AWARENESS_CONTEXT DpiAwareness => DpiUtilities.GetWindowDpiAwarenessContext(Handle);
    public string DpiAwarenessDescription => DpiUtilities.GetDpiAwarenessDescription(DpiAwareness);
    [SupportedOSPlatform("windows10.0.17134")]
    public uint DpiFromDpiAwareness => Functions.GetDpiFromDpiAwarenessContext(DpiAwareness);
    public virtual HWND ParentHandle { get => Functions.GetParent(Handle); set => Functions.SetParent(Handle, value); }
    public virtual RECT WindowRect { get { Functions.GetWindowRect(Handle, out var rc); return rc; } set => Functions.SetWindowPos(Handle, HWND.Null, value.left, value.top, value.Width, value.Height, SET_WINDOW_POS_FLAGS.SWP_NOACTIVATE | SET_WINDOW_POS_FLAGS.SWP_NOREDRAW | SET_WINDOW_POS_FLAGS.SWP_NOZORDER); }
    public virtual WINDOW_STYLE Style { get => (WINDOW_STYLE)Functions.GetWindowLongW(Handle, WINDOW_LONG_PTR_INDEX.GWL_STYLE); set => Functions.SetWindowLongW(Handle, WINDOW_LONG_PTR_INDEX.GWL_STYLE, (int)value); }
    public virtual WINDOW_EX_STYLE ExtendedStyle { get => (WINDOW_EX_STYLE)Functions.GetWindowLongW(Handle, WINDOW_LONG_PTR_INDEX.GWL_EXSTYLE); set => Functions.SetWindowLongW(Handle, WINDOW_LONG_PTR_INDEX.GWL_EXSTYLE, (int)value); }

    public HICON BigIconHandle
    {
        get => new() { Value = Functions.SendMessageW(Handle, MessageDecoder.WM_GETICON, new WPARAM { Value = Constants.ICON_BIG }).Value };
        set => Icon.Destroy(Functions.SendMessageW(Handle, MessageDecoder.WM_SETICON, new WPARAM { Value = Constants.ICON_BIG }, new LPARAM { Value = value.Value }).Value);
    }

    public HICON SmallIconHandle
    {
        get => new() { Value = Functions.SendMessageW(Handle, MessageDecoder.WM_GETICON, new WPARAM { Value = Constants.ICON_SMALL }).Value };
        set => Icon.Destroy(Functions.SendMessageW(Handle, MessageDecoder.WM_SETICON, new WPARAM { Value = Constants.ICON_SMALL }, new LPARAM { Value = value.Value }).Value);
    }

    protected string ClassName
    {
        get
        {
            using var p = new AllocPwstr(1024 * 2);
            if (Functions.GetClassNameW(Handle, p, (int)p.SizeInChars) > 0)
                return p.ToString() ?? string.Empty;
            return string.Empty;
        }
    }

    protected string RealClassName
    {
        get
        {
            using var p = new AllocPwstr(1024 * 2);
            if (Functions.RealGetWindowClassW(Handle, p, p.SizeInChars) > 0)
                return p.ToString() ?? string.Empty;
            return string.Empty;
        }
    }

    public virtual string Text
    {
        get
        {
            using var p = new AllocPwstr(1024 * 2);
            if (Functions.GetWindowTextW(Handle, p, (int)p.SizeInChars) > 0)
                return p.ToString() ?? string.Empty;
            return string.Empty;
        }
        set
        {
            value ??= string.Empty;
            Functions.SetWindowTextW(Handle, PWSTR.From(value));
        }
    }

    public IEnumerable<Window> ChildWindows => WindowUtilities.EnumerateChildWindows(Handle).Select(h => FromHandle(h.Value)).Where(w => w is not null)!;
    public IEnumerable<Window> AllChildWindows
    {
        get
        {
            foreach (var child in ChildWindows)
            {
                yield return child;
                foreach (var gchild in child.AllChildWindows)
                {
                    yield return gchild;
                }
            }
        }
    }

    public IEnumerable<Window> ParentWindows
    {
        get
        {
            var current = Parent;
            do
            {
                var parent = current;
                if (parent is null)
                    yield break;

                yield return parent;
                if (current is not null && current == parent)
                    break;

                current = parent;
            }
            while (true);
        }
    }

    public IReadOnlyCollection<Window> ProcessWindows
    {
        get
        {
            var list = new HashSet<Window>();
            var p = Process;
            if (p != null)
            {
                foreach (var child in FromProcess(p))
                {
                    list.Add(child);
                    foreach (var child2 in child.AllChildWindows)
                    {
                        list.Add(child2);
                    }
                }
            }
            return list;
        }
    }

    protected virtual internal bool ShowingFatalError() => true;

    public HMONITOR GetMonitorHandle(MONITOR_FROM_FLAGS flags) => Functions.MonitorFromWindow(Handle, flags);
    public Monitor? GetMonitor(MONITOR_FROM_FLAGS flags = MONITOR_FROM_FLAGS.MONITOR_DEFAULTTONULL) => Monitor.FromWindow(Handle, flags);
    public POINT ScreenToClient(POINT point) { Functions.ScreenToClient(Handle, ref point); return point; }
    public POINT ClientToScreen(POINT point) { Functions.ClientToScreen(Handle, ref point); return point; }
    public virtual HWND SetActive() => Functions.SetActiveWindow(Handle);
    public virtual HWND SetFocus() => Functions.SetFocus(Handle);
    public virtual void SwitchTo(bool useAltCtlTab) => Functions.SwitchToThisWindow(Handle, useAltCtlTab);
    public virtual bool BringToTop() => Functions.BringWindowToTop(Handle);
    public virtual bool Center() => WindowUtilities.Center(Handle, HWND.Null);
    public virtual bool Center(HWND alternateOwner) => WindowUtilities.Center(Handle, alternateOwner);
    public virtual bool Validate(RECT? rectangle = null) => Functions.ValidateRect(Handle, rectangle.CopyToPointer());
    public virtual bool Invalidate(RECT? rectangle = null, bool eraseBackground = true) => Functions.InvalidateRect(Handle, rectangle.CopyToPointer(), eraseBackground);
    public virtual bool SetForeground() => Functions.SetForegroundWindow(Handle);
    public virtual bool SetWindowPos(HWND hWndInsertAfter, int x, int y, int cx, int cy, SET_WINDOW_POS_FLAGS flags) => Functions.SetWindowPos(Handle, hWndInsertAfter, x, y, cx, cy, flags);
    public bool Hide() => Show(SHOW_WINDOW_CMD.SW_HIDE);
    public virtual bool Show(SHOW_WINDOW_CMD command = SHOW_WINDOW_CMD.SW_SHOW) => Functions.ShowWindow(Handle, command);
    public virtual void Move(int x, int y) => Functions.SetWindowPos(Handle, HWND.Null, x, y, -1, -1, SET_WINDOW_POS_FLAGS.SWP_NOSIZE | SET_WINDOW_POS_FLAGS.SWP_NOZORDER | SET_WINDOW_POS_FLAGS.SWP_NOACTIVATE);
    public virtual void Resize(int width, int height) => Functions.SetWindowPos(Handle, HWND.Null, 0, 0, width, height, SET_WINDOW_POS_FLAGS.SWP_NOMOVE | SET_WINDOW_POS_FLAGS.SWP_NOZORDER | SET_WINDOW_POS_FLAGS.SWP_NOACTIVATE);
    public virtual void ResizeAndMove(int x, int y, int width, int height) => Functions.SetWindowPos(Handle, HWND.Null, x, y, width, height, SET_WINDOW_POS_FLAGS.SWP_NOZORDER | SET_WINDOW_POS_FLAGS.SWP_NOACTIVATE);
    public virtual void ResizeClient(int width, int height)
    {
        var wr = WindowRect;
        var cr = ClientRect;
        Resize(width + (wr.Width - cr.Width), height + (wr.Height - cr.Height));
    }

    public override string ToString()
    {
        var str = UInt32Handle.ToString("X8");
        var cls = ClassName;
        if (!string.IsNullOrWhiteSpace(cls))
        {
            str += " | " + cls;
        }

        var text = Text;
        if (!string.IsNullOrWhiteSpace(text))
        {
            str += " | " + text;
        }
        return str;
    }

    public virtual Task RunTaskOnUIThread(Action action, bool startNew = false)
    {
        ArgumentNullException.ThrowIfNull(action);
        if (_scheduler == null)
            throw new DirectNException("0005: Cannot run or schedule a task on a non-owned window.");

        if (!startNew && Application.IsRunningAsUIThread)
        {
            action();
            return Task.CompletedTask;
        }

        return Task.Factory.StartNew(action, CancellationToken.None, TaskCreationOptions.None, _scheduler);
    }

    protected virtual void RunWithErrorHandled(Action action)
    {
        ArgumentNullException.ThrowIfNull(action);
        try
        {
            action();
        }
        catch (Exception ex)
        {
            HandleError(ex);
            throw;
        }
    }

    protected virtual async Task RunWithErrorHandledAsync(Func<Task> action)
    {
        ArgumentNullException.ThrowIfNull(action);
        try
        {
            await action();
        }
        catch (Exception ex)
        {
            HandleError(ex);
            throw;
        }
    }

    protected virtual T? RunWithErrorHandled<T>(Func<T> action)
    {
        ArgumentNullException.ThrowIfNull(action);
        try
        {
            return action();
        }
        catch (Exception ex)
        {
            HandleError(ex);
            throw;
        }
    }

    protected virtual async Task<T?> RunWithErrorHandledAsync<T>(Func<Task<T>> action)
    {
        ArgumentNullException.ThrowIfNull(action);
        try
        {
            return await action();
        }
        catch (Exception ex)
        {
            HandleError(ex);
            throw;
        }
    }

    protected virtual void HandleError(Exception error)
    {
        if (error == null)
            return;

        Application.AddError(error);
        if (Application.CanShowFatalError)
        {
            Application.ShowFatalError(new HWND { Value = Handle });
        }
        _ = RunTaskOnUIThread(Application.Exit);
    }

    protected virtual void OnFocusChanged(object? sender, HandledEventArgs e) => FocusChanged?.Invoke(sender, e);
    protected virtual void OnActivated(object? sender, HandledEventArgs e) => Activated?.Invoke(sender, e);
    protected virtual void OnDeactivated(object? sender, HandledEventArgs e) => Deactivated?.Invoke(sender, e);
    protected virtual void OnResized(object? sender, ValueEventArgs<(WindowResizedType ResizedType, SIZE Size)> e) => Resized?.Invoke(sender, e);
    protected virtual void OnDisposing(object? sender, CancelEventArgs e) => Disposing?.Invoke(sender, e);
    protected virtual void OnDestroyed(object? sender, EventArgs e) => Destroyed?.Invoke(sender, e);
    protected virtual void OnMoved(object? sender, HandledEventArgs e) => Moved?.Invoke(sender, e);
    protected virtual void OnCreated(object? sender, EventArgs e) => Created?.Invoke(sender, e); // after window has been created
    protected virtual void OnHandleCreated(object? sender, EventArgs e) => HandleCreated?.Invoke(sender, e); // inside window being created
    protected virtual void OnClosing(object? sender, CancelEventArgs e) => Closing?.Invoke(sender, e);

    protected virtual void RegisterClass(string className, nint windowProc, Icon? icon = null) => RegisterWindowClass(className, windowProc, icon: icon);

    protected virtual Icon? LoadCreationIcon() => Icon.LoadApplicationIcon();

    protected virtual void CreateWindow(
        string? text = null,
        WINDOW_STYLE style = WINDOW_STYLE.WS_POPUP | WINDOW_STYLE.WS_THICKFRAME | WINDOW_STYLE.WS_CAPTION | WINDOW_STYLE.WS_SYSMENU | WINDOW_STYLE.WS_MAXIMIZEBOX | WINDOW_STYLE.WS_MINIMIZEBOX,
        WINDOW_EX_STYLE extendedStyle = 0,
        RECT? rect = null,
        HWND? parentHandle = null,
        HMENU? menu = null,
        string? className = null
        )
    {
        className ??= GetType().FullName!;
        ArgumentNullException.ThrowIfNull(className);
        text ??= Application.GetTitle();
        var rc = rect ?? new RECT(Constants.CW_USEDEFAULT, Constants.CW_USEDEFAULT, Constants.CW_USEDEFAULT, Constants.CW_USEDEFAULT);
        _gcHandle = GCHandle.Alloc(this);
        var ptr = GCHandle.ToIntPtr(_gcHandle);
        var hwnd = Functions.CreateWindowExW(extendedStyle, PWSTR.From(className), PWSTR.From(text), style, rc.left, rc.top, rc.Width, rc.Height, parentHandle ?? HWND.Null, menu ?? HMENU.Null, HINSTANCE.Null, ptr);
        if (hwnd.Value == 0)
        {
            var gle = Marshal.GetLastPInvokeError();
            if (gle != 0)
                throw new Win32Exception(gle);

            throw new DirectNException("0004: Cannot create window.");
        }

        if (AboutSysMenuId != 0 && OperatingSystem.IsWindowsVersionAtLeast(10, 0, 17134, 0))
        {
            var sysMenu = Functions.GetSystemMenu(hwnd, false);
            if (sysMenu.Value != 0)
            {
                Functions.AppendMenuW(sysMenu, MENU_ITEM_FLAGS.MF_SEPARATOR, 0, PWSTR.Null);
                Functions.AppendMenuW(sysMenu, MENU_ITEM_FLAGS.MF_STRING, AboutSysMenuId, PWSTR.From($"About '{text}'..."));
            }
        }
    }

    protected virtual bool OnPaint(HDC hdc, PAINTSTRUCT ps)
    {
        return false;
    }

    protected virtual bool OnResized(WindowResizedType type, SIZE size)
    {
        var e = new ValueEventArgs<(WindowResizedType ResizedType, SIZE Size)>((type, size));
        OnResized(this, e);
        return e.Cancel;
    }

    protected virtual bool OnMoved()
    {
        var e = new HandledEventArgs();
        OnMoved(this, e);
        return false;
    }

    protected virtual bool OnFocusChanged()
    {
        var e = new HandledEventArgs();
        OnFocusChanged(this, e);
        return false;
    }

    protected virtual MINMAXINFO? GetMinMaxInfo(MINMAXINFO info)
    {
        return null;
    }

    protected virtual bool OnActivated(bool activated)
    {
        var e = new HandledEventArgs();
        if (activated)
        {
            OnActivated(this, e);
        }
        else
        {
            OnDeactivated(this, e);
        }
        return e.Handled;
    }

    protected virtual LRESULT? WindowProc(HWND hwnd, uint msg, WPARAM wParam, LPARAM lParam)
    {
        switch (msg)
        {
            case MessageDecoder.WM_CLOSE:
                var ec = new CancelEventArgs();
                OnClosing(this, ec);
                if (ec.Cancel)
                    return new();

                break;

            case MessageDecoder.WM_PAINT:
                if (ValidateOnPaint)
                {
                    var hdc = Functions.BeginPaint(Handle, out var ps);
                    var op = OnPaint(hdc, ps);
                    Functions.EndPaint(Handle, ps);
                    if (op)
                        return new();
                }
                break;

            case MessageDecoder.WM_ACTIVATE:
                if (OnActivated(wParam.Value != 0))
                    return new();
                break;

            case MessageDecoder.WM_SETFOCUS:
            case MessageDecoder.WM_KILLFOCUS:
                if (OnFocusChanged())
                    return new();
                break;

            case MessageDecoder.WM_GETMINMAXINFO:
                unsafe
                {
                    var mmi = *(MINMAXINFO*)lParam.Value;
                    var newMmi = GetMinMaxInfo(mmi);
                    if (newMmi != null)
                    {
                        *(MINMAXINFO*)lParam.Value = newMmi.Value;
                        return new();
                    }
                }
                break;

            case MessageDecoder.WM_SIZE:
                var sized = (WindowResizedType)wParam.Value.ToUInt64();
                if (sized == WindowResizedType.Minimized)
                    break;

                if (OnResized(sized, new SIZE(lParam.Value.LOWORD(), lParam.Value.HIWORD())))
                    return new();

                break;

            case MessageDecoder.WM_SYSCOMMAND:
                if (wParam.Value == AboutSysMenuId && OperatingSystem.IsWindowsVersionAtLeast(10, 0, 17134, 0))
                {
                    var di = CreateDiagnosticsInformation();
                    var sb = new StringBuilder();
#pragma warning disable IL2075 // 'this' argument does not satisfy 'DynamicallyAccessedMembersAttribute' in call to target method. The return value of the source method does not have matching annotations.
                    foreach (var item in di.GetType().GetProperties().OrderBy(p => p.Name))
                    {
                        sb.AppendLine($"{item.Name} : {item.GetValue(di)}");
                    }
#pragma warning restore IL2075 // 'this' argument does not satisfy 'DynamicallyAccessedMembersAttribute' in call to target method. The return value of the source method does not have matching annotations.

                    var td = new TaskDialog();
                    td.Flags |= TASKDIALOG_FLAGS.TDF_SIZE_TO_CONTENT;
                    td.MainIcon = TaskDialog.TD_INFORMATION_ICON;
                    td.Title = $"About '{Text}'";
                    td.MainInstruction = "System Information";
                    td.Content = sb.ToString();
                    td.Show(hwnd);
                }
                break;

            case MessageDecoder.WM_MOVE:
                if (OnMoved())
                    return null;

                break;

            case WM_PROCESS_TASKS:
                ProcessTasks();
                break;

            case WM_WINDOW_CREATED:
                OnCreated(this, EventArgs.Empty);
                break;

            case MessageDecoder.WM_DESTROY:
                DestroyOnDispose = false;
                Dispose();
                break;
        }
        return null; // unhandled
    }

    [SupportedOSPlatform("windows10.0.17134")]
    protected virtual DiagnosticsInformation CreateDiagnosticsInformation() => new();

    protected virtual void Dispose(bool disposing)
    {
        if (!disposing)
            return;

        var isDisposing = Interlocked.CompareExchange(ref _disposeState, 1, 0);
        if (isDisposing != 0)
            return;

        var e = new CancelEventArgs();
        OnDisposing(this, e);
        if (e.Cancel)
            return;

        Application.RemoveWindow(this);
        var handle = Interlocked.Exchange(ref _handle, 0);
        if (handle != 0)
        {
            Functions.RemovePropW(new HWND { Value = handle }, PWSTR.From(_handlePropName));
            if (_gcHandle.IsAllocated)
            {
                _gcHandle.Free();
            }

            if (DestroyOnDispose)
            {
                Functions.DestroyWindow(new HWND { Value = handle });
                OnDestroyed(this, EventArgs.Empty);
            }
        }

        Interlocked.Exchange(ref _disposeState, 2);
    }

    ~Window() { Dispose(disposing: false); }
    public void Dispose() { Dispose(disposing: true); GC.SuppressFinalize(this); }

    public static Window? FromHandle(nint handle, bool tryWindowType = true)
    {
        if (handle == 0)
            return null;

        // try a window created by us
        var hwnd = new HWND { Value = handle };
        if (tryWindowType)
        {
            var windowPtr = Functions.GetPropW(hwnd, PWSTR.From(_handlePropName));
            if (windowPtr.Value != 0)
            {
                try
                {
                    var gch = GCHandle.FromIntPtr(windowPtr.Value);
                    if (gch.Target is Window window)
                        return window;
                }
                catch
                {
                    // continue
                }
            }
        }

        if (!Functions.IsWindow(hwnd))
            return null;

        // wrap it
        return new Window(handle);
    }

    public static Window? FromPoint(POINT point) => FromHandle(Functions.WindowFromPoint(point).Value);
    public static Window? FromPhysicalPoint(POINT point) => FromHandle(Functions.WindowFromPhysicalPoint(point).Value);
    public static IEnumerable<Window> FromProcess(int processId) => WindowUtilities.EnumerateProcessWindows(processId).Select(h => FromHandle(h.Value)).Where(p => p is not null)!;
    public static IEnumerable<Window> FromProcess(Process process) => WindowUtilities.EnumerateProcessWindows(process).Select(h => FromHandle(h.Value)).Where(p => p is not null)!;

    public static Window? Console => FromHandle(Functions.GetConsoleWindow().Value, false);
    public static Window? Active => FromHandle(Functions.GetActiveWindow().Value);
    public static Window? Foreground => FromHandle(Functions.GetForegroundWindow().Value);
    public static Window? Desktop => FromHandle(Functions.GetDesktopWindow().Value, false);
    public static Window? Shell => FromHandle(Functions.GetShellWindow().Value, false);
    public static WNDPROC DefWindowProc { get; } = GetDefWindowProc();
    private static WNDPROC GetDefWindowProc() => Marshal.GetDelegateForFunctionPointer<WNDPROC>(Functions.GetProcAddress(Functions.GetModuleHandleW(PWSTR.From("user32.dll")), PSTR.From("DefWindowProcW")));

    private static LRESULT SafeWindowProc(HWND hwnd, uint msg, WPARAM wParam, LPARAM lParam)
    {
        try
        {
            if (Debugger.IsAttached)
                return StaticWindowProc(hwnd, msg, wParam, lParam);

            try
            {
                return StaticWindowProc(hwnd, msg, wParam, lParam);
            }
            catch (Exception e)
            {
                Application.AddError(e);
                return LRESULT.Null;
            }
        }
        catch (Exception e)
        {
            Application.TraceError(e);
            throw;
        }
    }

    private static readonly string _handlePropName = "DirectNWindow" + AssemblyUtilities.GetInformationalVersion();
    private static LRESULT StaticWindowProc(HWND hwnd, uint msg, WPARAM wParam, LPARAM lParam)
    {
        if (Application.Current.TraceMessage(msg))
        {
            var str = MessageDecoder.Decode(hwnd, msg, wParam, lParam);
            Application.TraceVerbose(str);
        }

        if (!Application.IsFatalErrorShowing)
        {
            if (msg == MessageDecoder.WM_NCCREATE)
            {
                nint ptr;
                unsafe
                {
                    ptr = *(nint*)lParam.Value; // first parameter of CREATESTRUCTW is lpCreateParams
                }

                var gch = GCHandle.FromIntPtr(ptr);
                var w = ((Window)gch.Target!);
                w._handle = hwnd.Value;
                Functions.SetPropW(hwnd, PWSTR.From(_handlePropName), new HANDLE { Value = ptr });
                w.OnHandleCreated(w, EventArgs.Empty);
                Functions.PostMessageW(hwnd, WM_WINDOW_CREATED);
                return DefWindowProc(hwnd, msg, wParam, lParam);
            }

            var win = FromHandle(hwnd.Value);
            if (win != null)
            {
                var result = win.WindowProc(hwnd, msg, wParam, lParam);
                if (result.HasValue)
                    return result.Value;
            }
        }
        return DefWindowProc(hwnd, msg, wParam, lParam);
    }

    public static bool RegisterWindowClass(
        string className,
        nint windowProc,
        WNDCLASS_STYLES styles = WNDCLASS_STYLES.CS_HREDRAW | WNDCLASS_STYLES.CS_VREDRAW,
        Icon? icon = null,
        Cursor? cursor = null,
        HBRUSH? background = null,
        string? menuName = null,
        int classExtraBytesSize = 0,
        int windowExtraBytesSize = 0)
    {
        ArgumentNullException.ThrowIfNull(className);
        if (windowProc == 0)
            throw new ArgumentException(null, nameof(windowProc));

        if (Functions.GetClassInfoW(new HINSTANCE { Value = Application.ModuleHandle.Value }, PWSTR.From(className), out _))
            return false;

        var cls = new WNDCLASSW
        {
            style = styles,
            lpfnWndProc = windowProc,
            hInstance = new HINSTANCE { Value = Application.ModuleHandle.Value },
            lpszClassName = PWSTR.From(className),
            hIcon = icon?.Handle ?? HICON.Null,
            hCursor = cursor?.Handle ?? Cursor.Arrow.Handle,
            lpszMenuName = PWSTR.From(menuName),
            cbClsExtra = classExtraBytesSize,
            cbWndExtra = windowExtraBytesSize
        };

        if (background.HasValue)
        {
            cls.hbrBackground = background.Value;
        }
        else
        {
            cls.hbrBackground = new HBRUSH { Value = (nint)SYS_COLOR_INDEX.COLOR_WINDOW + 1 };
        }

        if (Functions.RegisterClassW(cls) == 0)
            throw new Win32Exception(Marshal.GetLastWin32Error());

        return true;
    }

    public override int GetHashCode() => _handle.GetHashCode();
    public override bool Equals(object? obj) => Equals(obj as Window);
    public bool Equals(Window? other) => other is not null && other._handle == _handle;
    public static bool operator ==(Window? left, Window? right) => left is not null && right is not null && left._handle == right._handle;
    public static bool operator !=(Window? left, Window? right) => left is null || right is null || left._handle != right._handle;

    private void ProcessTasks()
    {
        var tasks = Interlocked.Exchange(ref _tasks, new());
        if (tasks == null || tasks.IsEmpty || _scheduler == null)
            return;

        foreach (var task in tasks)
        {
            if (!_scheduler.TryExecuteTask(task))
                throw new InvalidOperationException();
        }
    }

    private Process? GetProcess()
    {
        if (ProcessId <= 0)
            return null;

        try
        {
            return Process.GetProcessById(ProcessId);
        }
        catch
        {
            return null;
        }
    }

    private sealed class Scheduler(Window window) : TaskScheduler
    {
        protected override bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued) => false;
        protected override IEnumerable<Task> GetScheduledTasks() => window._tasks ?? Enumerable.Empty<Task>();
        protected override void QueueTask(Task task)
        {
            ArgumentNullException.ThrowIfNull(task);
            if (window._tasks == null || window._scheduler == null)
                return;

            window._tasks.Enqueue(task);
            Functions.PostMessageW(window.Handle, WM_PROCESS_TASKS);
        }

        public new bool TryExecuteTask(Task task) => base.TryExecuteTask(task);
    }
}
