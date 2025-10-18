namespace DirectN.Extensions.Utilities;

public class Tooltip : IDisposable
{
    private Pwstr? _text;
    private HWND _handle;

    private Tooltip(HWND handle)
    {
        _handle = handle;
    }

    public HWND Handle => _handle;
    public bool IsDisposed => _handle == HWND.Null;

    public static unsafe Tooltip Create(HWND parent, HINSTANCE instance, string text, TOOLTIP_FLAGS flags = TOOLTIP_FLAGS.TTF_SUBCLASS)
    {
        ArgumentNullException.ThrowIfNull(text);

        var hwnd = Functions.CreateWindowExW(
            WINDOW_EX_STYLE.WS_EX_TOPMOST,
            PWSTR.From(Constants.TOOLTIPS_CLASSW),
            PWSTR.Null,
            WINDOW_STYLE.WS_POPUP | (WINDOW_STYLE)(Constants.TTS_ALWAYSTIP | Constants.TTS_NOPREFIX),
            Constants.CW_USEDEFAULT, Constants.CW_USEDEFAULT, Constants.CW_USEDEFAULT, Constants.CW_USEDEFAULT,
            parent, HMENU.Null, instance, 0);

        Functions.SetWindowPos(hwnd, HWND.TOPMOST, 0, 0, 0, 0, SET_WINDOW_POS_FLAGS.SWP_NOMOVE | SET_WINDOW_POS_FLAGS.SWP_NOSIZE | SET_WINDOW_POS_FLAGS.SWP_NOACTIVATE);

        var ti = new TTTOOLINFOW
        {
            cbSize = (uint)sizeof(TTTOOLINFOW),
            uFlags = flags,
            hwnd = parent,
            hinst = instance,
        };

        if (flags.HasFlag(TOOLTIP_FLAGS.TTF_IDISHWND))
        {
            ti.uId = (nuint)parent.Value;
        }

        var tt = new Tooltip(hwnd)
        {
            _text = new Pwstr(text)
        };
        ti.lpszText = tt._text;

        Functions.GetClientRect(parent, out var rc);
        ti.rect = rc;

        Functions.SendMessageW(hwnd, Constants.TTM_ADDTOOL, 0, (nint)(&ti));

        Functions.SendMessageW(hwnd, Constants.TTM_UPDATETIPTEXT, 0, (nint)(&ti));
        return tt;
    }

    public virtual void Activate(bool activate)
    {
        ObjectDisposedException.ThrowIf(IsDisposed, this);
        Functions.SendMessageW(_handle, Constants.TTM_ACTIVATE, activate ? 1 : 0, 0);
    }

    public virtual void Popup()
    {
        ObjectDisposedException.ThrowIf(IsDisposed, this);
        Functions.SendMessageW(_handle, Constants.TTM_POPUP, 0, 0);
    }

    public virtual void Pop()
    {
        ObjectDisposedException.ThrowIf(IsDisposed, this);
        Functions.SendMessageW(_handle, Constants.TTM_POP, 0, 0);
    }

    public virtual unsafe void TrackActivate(bool activate)
    {
        ObjectDisposedException.ThrowIf(IsDisposed, this);
        var ti = new TTTOOLINFOW
        {
            cbSize = (uint)sizeof(TTTOOLINFOW),
            hwnd = _handle
        };
        Functions.SendMessageW(_handle, Constants.TTM_TRACKACTIVATE, activate ? 1 : 0, (nint)(&ti));
    }

    public void TrackPosition(POINT pt) => TrackPosition(pt.x, pt.y);
    public virtual unsafe void TrackPosition(int x, int y)
    {
        ObjectDisposedException.ThrowIf(IsDisposed, this);
        var lp = (nint)((y << 16) | (x & 0xFFFF));
        Functions.SendMessageW(_handle, Constants.TTM_TRACKPOSITION, 0, lp);
    }

    public virtual unsafe bool RelayEvent(MSG msg)
    {
        ObjectDisposedException.ThrowIf(IsDisposed, this);
        switch (msg.message)
        {
            case MessageDecoder.WM_LBUTTONDOWN:
            case MessageDecoder.WM_LBUTTONUP:
            case MessageDecoder.WM_MBUTTONDOWN:
            case MessageDecoder.WM_MBUTTONUP:
            case MessageDecoder.WM_MOUSEMOVE:
            case MessageDecoder.WM_NCMOUSEMOVE:
            case MessageDecoder.WM_RBUTTONDOWN:
            case MessageDecoder.WM_RBUTTONUP:
                Functions.SendMessageW(_handle, Constants.TTM_RELAYEVENT, 0, (nint)(&msg));
                return true;
        }
        return false;
    }

    public override string ToString() => $"Handle={_handle} '{_text?.ToString()}'";

    public void Dispose() { Dispose(disposing: true); GC.SuppressFinalize(this); }
    protected virtual void Dispose(bool disposing)
    {
        if (disposing)
        {
            var hwnd = Interlocked.Exchange(ref _handle, HWND.Null);
            if (hwnd != HWND.Null)
            {
                Functions.DestroyWindow(hwnd);
            }
            Interlocked.Exchange(ref _text, null)?.Dispose();
        }
    }
}
