#nullable enable
namespace DirectN;

public partial struct D3D12_VIDEO_ENCODER_RATE_CONTROL_VBR1
{
    public uint InitialQP;
    public uint MinQP;
    public uint MaxQP;
    public ulong MaxFrameBitSize;
    public ulong TargetAvgBitRate;
    public ulong PeakBitRate;
    public ulong VBVCapacity;
    public ulong InitialVBVFullness;
    public uint QualityVsSpeed;
}
