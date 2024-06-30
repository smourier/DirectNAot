#nullable enable
namespace DirectN;

public partial struct KSPIN_CONNECT
{
    public KSIDENTIFIER Interface;
    public KSIDENTIFIER Medium;
    public uint PinId;
    public HANDLE PinToHandle;
    public KSPRIORITY Priority;
}
