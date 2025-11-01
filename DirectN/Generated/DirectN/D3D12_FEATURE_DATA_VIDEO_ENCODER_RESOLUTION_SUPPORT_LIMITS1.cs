#nullable enable
namespace DirectN;

public partial struct D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOLUTION_SUPPORT_LIMITS1
{
    public uint MaxSubregionsNumber;
    public uint MaxIntraRefreshFrameDuration;
    public uint SubregionBlockPixelsSize;
    public uint QPMapRegionPixelsSize;
    public D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOLUTION_SUPPORT_QPMAP QPMap;
    public D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOLUTION_SUPPORT_DIRTY_REGIONS DirtyRegions;
    public D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOLUTION_SUPPORT_MOTION_SEARCH MotionSearch;
    public D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOLUTION_SUPPORT_FRAME_ANALYSIS FrameAnalysis;
}
