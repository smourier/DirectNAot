#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ns-d3d12video-d3d12_feature_data_video_encoder_output_resolution_ratios_count
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_FEATURE_DATA_VIDEO_ENCODER_OUTPUT_RESOLUTION_RATIOS_COUNT
{
    public uint NodeIndex;
    public D3D12_VIDEO_ENCODER_CODEC Codec;
    public uint ResolutionRatiosCount;
}
