#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/contentpartner/ns-contentpartner-wmpcontextmenuinfo
[StructLayout(LayoutKind.Sequential)]
public partial struct WMPContextMenuInfo
{
    public uint dwID;
    public BSTR bstrMenuText;
    public BSTR bstrHelpText;
}
