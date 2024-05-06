#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mmeapi/ns-mmeapi-mixercontroldetails_listtexta
[StructLayout(LayoutKind.Sequential)]
public partial struct MIXERCONTROLDETAILS_LISTTEXTA
{
    public uint dwParam1;
    public uint dwParam2;
    public InlineArrayFoundationCHAR_64 szName;
}
