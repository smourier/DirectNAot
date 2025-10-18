#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/commctrl/ns-commctrl-tthittestinfow
public partial struct TTHITTESTINFOW
{
    public HWND hwnd;
    public POINT pt;
    public TTTOOLINFOW ti;
}
