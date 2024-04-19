namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct BDA_TRANSPORT_INFO
{
    public uint ulcbPhyiscalPacket;
    public uint ulcbPhyiscalFrame;
    public uint ulcbPhyiscalFrameAlignment;
    public long AvgTimePerFrame;
}
