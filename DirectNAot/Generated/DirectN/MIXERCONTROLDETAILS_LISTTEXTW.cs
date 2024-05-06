#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mmeapi/ns-mmeapi-mixercontroldetails_listtextw
[StructLayout(LayoutKind.Sequential)]
public partial struct MIXERCONTROLDETAILS_LISTTEXTW
{
    public uint dwParam1;
    public uint dwParam2;
    public InlineArraySystemChar_64 szName;
}
