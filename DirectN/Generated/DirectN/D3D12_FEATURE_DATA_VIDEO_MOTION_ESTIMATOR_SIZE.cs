#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ns-d3d12video-d3d12_feature_data_video_motion_estimator_size
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_FEATURE_DATA_VIDEO_MOTION_ESTIMATOR_SIZE
{
    public uint NodeIndex;
    public DXGI_FORMAT InputFormat;
    public D3D12_VIDEO_MOTION_ESTIMATOR_SEARCH_BLOCK_SIZE BlockSize;
    public D3D12_VIDEO_MOTION_ESTIMATOR_VECTOR_PRECISION Precision;
    public D3D12_VIDEO_SIZE_RANGE SizeRange;
    public BOOL Protected;
    public ulong MotionVectorHeapMemoryPoolL0Size;
    public ulong MotionVectorHeapMemoryPoolL1Size;
    public ulong MotionEstimatorMemoryPoolL0Size;
    public ulong MotionEstimatorMemoryPoolL1Size;
}
