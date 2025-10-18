#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/commctrl/ns-commctrl-tttoolinfow
public partial struct TTTOOLINFOW
{
    public uint cbSize;
    public TOOLTIP_FLAGS uFlags;
    public HWND hwnd;
    public nuint uId;
    public RECT rect;
    public HINSTANCE hinst;
    public PWSTR lpszText;
    public LPARAM lParam;
    public nint lpReserved;
}
