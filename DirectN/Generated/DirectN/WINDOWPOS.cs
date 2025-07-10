#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winuser/ns-winuser-windowpos
public partial struct WINDOWPOS
{
    public HWND hwnd;
    public HWND hwndInsertAfter;
    public int x;
    public int y;
    public int cx;
    public int cy;
    public SET_WINDOW_POS_FLAGS flags;
}
