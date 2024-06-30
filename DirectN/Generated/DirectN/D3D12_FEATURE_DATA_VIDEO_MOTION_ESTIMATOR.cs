#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ns-d3d12video-d3d12_feature_data_video_motion_estimator
public partial struct D3D12_FEATURE_DATA_VIDEO_MOTION_ESTIMATOR
{
    public uint NodeIndex;
    public DXGI_FORMAT InputFormat;
    public D3D12_VIDEO_MOTION_ESTIMATOR_SEARCH_BLOCK_SIZE_FLAGS BlockSizeFlags;
    public D3D12_VIDEO_MOTION_ESTIMATOR_VECTOR_PRECISION_FLAGS PrecisionFlags;
    public D3D12_VIDEO_SIZE_RANGE SizeRange;
}
