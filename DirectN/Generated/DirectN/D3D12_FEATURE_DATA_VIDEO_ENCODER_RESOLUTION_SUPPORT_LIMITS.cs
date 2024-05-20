#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ns-d3d12video-d3d12_feature_data_video_encoder_resolution_support_limits
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOLUTION_SUPPORT_LIMITS
{
    public uint MaxSubregionsNumber;
    public uint MaxIntraRefreshFrameDuration;
    public uint SubregionBlockPixelsSize;
    public uint QPMapRegionPixelsSize;
}
