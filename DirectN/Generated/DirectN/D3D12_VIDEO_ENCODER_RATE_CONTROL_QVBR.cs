#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ns-d3d12video-d3d12_video_encoder_rate_control_qvbr
public partial struct D3D12_VIDEO_ENCODER_RATE_CONTROL_QVBR
{
    public uint InitialQP;
    public uint MinQP;
    public uint MaxQP;
    public ulong MaxFrameBitSize;
    public ulong TargetAvgBitRate;
    public ulong PeakBitRate;
    public uint ConstantQualityTarget;
}
