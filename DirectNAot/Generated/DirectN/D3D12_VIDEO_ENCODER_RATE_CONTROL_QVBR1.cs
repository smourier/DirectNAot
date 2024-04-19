namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_VIDEO_ENCODER_RATE_CONTROL_QVBR1
{
    public uint InitialQP;
    public uint MinQP;
    public uint MaxQP;
    public ulong MaxFrameBitSize;
    public ulong TargetAvgBitRate;
    public ulong PeakBitRate;
    public uint ConstantQualityTarget;
    public ulong VBVCapacity;
    public ulong InitialVBVFullness;
    public uint QualityVsSpeed;
}
