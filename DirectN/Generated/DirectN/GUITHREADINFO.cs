#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winuser/ns-winuser-guithreadinfo
public partial struct GUITHREADINFO
{
    public uint cbSize;
    public GUITHREADINFO_FLAGS flags;
    public HWND hwndActive;
    public HWND hwndFocus;
    public HWND hwndCapture;
    public HWND hwndMenuOwner;
    public HWND hwndMoveSize;
    public HWND hwndCaret;
    public RECT rcCaret;
}
