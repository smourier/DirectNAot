#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSPIN_CONNECT
{
    public KSIDENTIFIER Interface;
    public KSIDENTIFIER Medium;
    public uint PinId;
    public HANDLE PinToHandle;
    public KSPRIORITY Priority;
}
