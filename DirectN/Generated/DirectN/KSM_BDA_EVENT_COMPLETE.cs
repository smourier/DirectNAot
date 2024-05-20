#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSM_BDA_EVENT_COMPLETE
{
    public KSIDENTIFIER Method;
    public uint ulEventID;
    public uint ulEventResult;
}
