#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/commctrl/ns-commctrl-initcommoncontrolsex
public partial struct INITCOMMONCONTROLSEX
{
    public uint dwSize;
    public INITCOMMONCONTROLSEX_ICC dwICC;
}
