namespace DirectN.Extensions.Utilities;

public class NotifyIcon : IDisposable
{
    protected static WNDPROC DefWindowProc { get; } = Marshal.GetDelegateForFunctionPointer<WNDPROC>(Functions.GetProcAddress(Functions.GetModuleHandleW(PWSTR.From("user32.dll")), PSTR.From("DefWindowProcW")));

    private NotifyIconNativeWindow? _window;
    private string _text = string.Empty;
    private bool _added;
    private bool _visible;
    private HICON _iconHandle;

    public event EventHandler<ValueEventArgs<POINT>>? MenuOpening;

    public NotifyIcon()
    {
        TaskbarCreatedMessage = Functions.RegisterWindowMessageW(PWSTR.From("TaskbarCreated"));
        TrayMouseMessage = MessageDecoder.WM_USER + 1024;
        _window = new NotifyIconNativeWindow(this);
        UpdateIcon(_visible);
    }

    protected virtual uint TrayMouseMessage { get; }
    protected virtual uint TaskbarCreatedMessage { get; }
    public HWND WindowHandle => _window?.Handle ?? HWND.Null;

    public virtual bool Visible
    {
        get => _visible;
        set
        {
            if (_visible == value)
                return;

            UpdateIcon(value);
            _visible = value;
        }
    }

    public virtual string Text
    {
        get => _text;
        set
        {
            if (value == _text)
                return;

            value ??= string.Empty;
            if (value.Length > 128)
            {
                value = value[..128];
            }

            _text = value;
            if (_added)
            {
                UpdateIcon(true);
            }
        }
    }

    public virtual HICON IconHandle
    {
        get => _iconHandle;
        set
        {
            if (_iconHandle == value)
                return;

            _iconHandle = value;
            if (_added)
            {
                UpdateIcon(true);
            }
        }
    }

    public void SetFocusToNotificationArea() => SetFocusToNotificationArea((_window?.Handle).GetValueOrDefault());
    public unsafe static void SetFocusToNotificationArea(HWND handle)
    {
        var data = new NOTIFYICONDATAW
        {
            cbSize = (uint)sizeof(NOTIFYICONDATAW),
            hWnd = handle
        };
        Functions.Shell_NotifyIconW(NOTIFY_ICON_MESSAGE.NIM_SETFOCUS, data);
    }

    public static void CloseNotificationArea()
    {
        // note when waiting a bit the notification window goes away automatically
        // but this is a hack of some sort... I have not found a way to do it better
        var handle = Functions.FindWindowW(PWSTR.From("NotifyIconOverflowWindow"), PWSTR.Null);
        if (handle != 0)
        {
            Functions.SendMessageW(handle, MessageDecoder.WM_CLOSE, 0, 0);
        }
        else
        {
            // windows 11
            handle = Functions.FindWindowW(PWSTR.From("TopLevelWindowForOverflowXamlIsland"), PWSTR.Null);
            if (handle != 0)
            {
                Functions.ShowWindow(handle, SHOW_WINDOW_CMD.SW_HIDE);
            }
        }
    }

    private unsafe void UpdateIcon(bool showIconInTray)
    {
        var window = _window;
        if (window == null)
            return;

        var data = new NOTIFYICONDATAW
        {
            cbSize = (uint)sizeof(NOTIFYICONDATAW),
            uCallbackMessage = TrayMouseMessage,
            uFlags = NOTIFY_ICON_DATA_FLAGS.NIF_MESSAGE | NOTIFY_ICON_DATA_FLAGS.NIF_TIP | NOTIFY_ICON_DATA_FLAGS.NIF_SHOWTIP,
            Anonymous = new NOTIFYICONDATAW._Anonymous_e__Union { uVersion = Constants.NOTIFYICON_VERSION_4 },
            hWnd = window.Handle
        };

        if (IconHandle != 0)
        {
            data.uFlags |= NOTIFY_ICON_DATA_FLAGS.NIF_ICON;
            data.hIcon = IconHandle;
        }

        data.szTip = Text;

        if (showIconInTray && IconHandle != 0)
        {
            if (!_added)
            {
                if (!Functions.Shell_NotifyIconW(NOTIFY_ICON_MESSAGE.NIM_ADD, data))
                    throw new Win32Exception(Marshal.GetLastWin32Error());

                Functions.Shell_NotifyIconW(NOTIFY_ICON_MESSAGE.NIM_SETVERSION, data);
                _added = true;
            }
            else
            {
                Functions.Shell_NotifyIconW(NOTIFY_ICON_MESSAGE.NIM_MODIFY, data);
            }
        }
        else if (_added)
        {
            Functions.Shell_NotifyIconW(NOTIFY_ICON_MESSAGE.NIM_DELETE, data);
            _added = false;
        }
    }

    protected virtual void OnMenuOpening(object? sender, ValueEventArgs<POINT> e) => MenuOpening?.Invoke(sender, e);

    // if needed, override to handle specific events
    protected virtual LRESULT WindowProc(HWND hWnd, uint msg, WPARAM wParam, LPARAM lParam)
    {
        var x = wParam.Value.SignedLOWORD();
        var y = wParam.Value.SignedHIWORD();

        if (msg == TrayMouseMessage)
        {
            var tmsg = (uint)lParam.Value.ToInt64();

            switch (tmsg)
            {
                case MessageDecoder.WM_LBUTTONDBLCLK:
                    break;

                case MessageDecoder.WM_LBUTTONDOWN:
                    break;

                case MessageDecoder.WM_LBUTTONUP:
                    OnMenuOpening(this, new ValueEventArgs<POINT>(new POINT(x, y)));
                    CloseNotificationArea();
                    break;

                case MessageDecoder.WM_MBUTTONDBLCLK:
                    break;

                case MessageDecoder.WM_MBUTTONDOWN:
                    break;

                case MessageDecoder.WM_MBUTTONUP:
                    break;

                case MessageDecoder.WM_MOUSEMOVE:
                    break;

                case MessageDecoder.WM_RBUTTONDBLCLK:
                    break;

                case MessageDecoder.WM_RBUTTONDOWN:
                    break;

                case MessageDecoder.WM_RBUTTONUP:
                    OnMenuOpening(this, new ValueEventArgs<POINT>(new POINT(x, y)));
                    CloseNotificationArea();
                    break;

                case Constants.NIN_BALLOONSHOW:
                    break;

                case Constants.NIN_BALLOONHIDE:
                    break;

                case Constants.NIN_BALLOONTIMEOUT:
                    break;

                case Constants.NIN_BALLOONUSERCLICK:
                    break;

                case Constants.NIN_POPUPOPEN:
                    break;

                case Constants.NIN_POPUPCLOSE:
                    break;
            }
        }
        else if (msg == TaskbarCreatedMessage)
        {
            _added = false;
            UpdateIcon(_visible);
        }
        else
        {
            switch (msg)
            {
                case MessageDecoder.WM_COMMAND:
                    break;

                case MessageDecoder.WM_ACTIVATEAPP:
                    return 0;

                case MessageDecoder.WM_DESTROY:
                    UpdateIcon(false);
                    break;
            }
        }
        return DefWindowProc(hWnd, msg, wParam, lParam);
    }

    private sealed class NotifyIconNativeWindow : IDisposable
    {
        private static readonly WNDPROC _windowProc = WindowProc;
        private static readonly ConcurrentDictionary<IntPtr, NotifyIconNativeWindow> _windows = new();
        private static readonly ConcurrentDictionary<IntPtr, NotifyIconNativeWindow> _windowsBeingCreated = new();
        private static long _createIndex;

        private readonly NotifyIcon _notifyIcon;
        private nint _handle;

        public NotifyIconNativeWindow(NotifyIcon notifyIcon)
        {
            _notifyIcon = notifyIcon;

            var wc = new WNDCLASSW
            {
                lpfnWndProc = Marshal.GetFunctionPointerForDelegate(_windowProc),
                lpszClassName = PWSTR.From(GetType().FullName)
            };

            var index = (nint)Interlocked.Increment(ref _createIndex);
            _windowsBeingCreated[index] = this;

            if (Functions.RegisterClassW(wc) == 0)
            {
                // we always register the same class name, so "already exists" is expected
                var gle = Marshal.GetLastWin32Error();
                if ((WIN32_ERROR)gle != WIN32_ERROR.ERROR_CLASS_ALREADY_EXISTS)
                    throw new Win32Exception(gle);
            }

            _handle = Functions.CreateWindowExW(
                WINDOW_EX_STYLE.WS_EX_NOACTIVATE,
                wc.lpszClassName,
                PWSTR.From(nameof(NotifyIconNativeWindow)),
                0,
                Constants.CW_USEDEFAULT, Constants.CW_USEDEFAULT, Constants.CW_USEDEFAULT, Constants.CW_USEDEFAULT,
                HWND.Null,
                0,
                new HINSTANCE { Value = Functions.GetModuleHandleW(PWSTR.Null) },
                index);
            if (_handle == 0)
                throw new Win32Exception(Marshal.GetLastWin32Error());
        }

        public HWND Handle => _handle;

        public void Dispose()
        {
            var handle = Interlocked.Exchange(ref _handle, 0);
            if (handle != 0)
            {
                Functions.SendMessageW(handle, MessageDecoder.WM_CLOSE, 0, 0);
            }
        }

        private static LRESULT WindowProc(HWND hWnd, uint msg, WPARAM wParam, LPARAM lParam)
        {
            if (msg == MessageDecoder.WM_CREATE && lParam != 0)
            {
                var userData = Marshal.ReadIntPtr(lParam);
                if (_windowsBeingCreated.TryRemove(userData, out var win))
                {
                    _windows[hWnd] = win;
                }
            }

            _windows.TryGetValue(hWnd, out var nativeWindow);
            var notifyIcon = nativeWindow?._notifyIcon;
            if (notifyIcon != null)
            {
                if (msg == MessageDecoder.WM_NCDESTROY)
                {
                    // this is the very last message the window can receive, remove it from the list
                    _windows.TryRemove(hWnd, out _);
                }
                return notifyIcon.WindowProc(hWnd, msg, wParam, lParam);
            }

            return DefWindowProc(hWnd, msg, wParam, lParam);
        }
    }

    protected virtual void Dispose(bool disposing)
    {
        if (disposing)
        {
            UpdateIcon(false);
            Interlocked.Exchange(ref _window, null)?.Dispose();
            _iconHandle = HICON.Null;
        }
    }

    ~NotifyIcon() { Dispose(disposing: false); }
    public void Dispose() { Dispose(disposing: true); GC.SuppressFinalize(this); }
}
