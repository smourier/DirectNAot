namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSAUDIOENGINE_DESCRIPTOR
{
    public uint nHostPinId;
    public uint nOffloadPinId;
    public uint nLoopbackPinId;
}
