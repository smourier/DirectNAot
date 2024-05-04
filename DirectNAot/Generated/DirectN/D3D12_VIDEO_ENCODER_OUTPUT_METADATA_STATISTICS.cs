#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ns-d3d12video-d3d12_video_encoder_output_metadata_statistics
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_VIDEO_ENCODER_OUTPUT_METADATA_STATISTICS
{
    public ulong AverageQP;
    public ulong IntraCodingUnitsCount;
    public ulong InterCodingUnitsCount;
    public ulong SkipCodingUnitsCount;
    public ulong AverageMotionEstimationXDirection;
    public ulong AverageMotionEstimationYDirection;
}
