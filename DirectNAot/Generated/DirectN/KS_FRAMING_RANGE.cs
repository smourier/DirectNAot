namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KS_FRAMING_RANGE
{
    public uint MinFrameSize;
    public uint MaxFrameSize;
    public uint Stepping;
}
