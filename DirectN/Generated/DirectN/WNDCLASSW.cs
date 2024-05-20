#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winuser/ns-winuser-wndclassw
[StructLayout(LayoutKind.Sequential)]
public partial struct WNDCLASSW
{
    public WNDCLASS_STYLES style;
    public nint lpfnWndProc;
    public int cbClsExtra;
    public int cbWndExtra;
    public HINSTANCE hInstance;
    public HICON hIcon;
    public HCURSOR hCursor;
    public HBRUSH hbrBackground;
    public PWSTR lpszMenuName;
    public PWSTR lpszClassName;
}
