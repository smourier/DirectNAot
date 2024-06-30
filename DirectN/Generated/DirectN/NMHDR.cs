#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winuser/ns-winuser-nmhdr
public partial struct NMHDR
{
    public HWND hwndFrom;
    public nuint idFrom;
    public uint code;
}
