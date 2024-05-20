#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ne-d3d12video-d3d12_video_motion_estimator_vector_precision_flags
[Flags]
public enum D3D12_VIDEO_MOTION_ESTIMATOR_VECTOR_PRECISION_FLAGS
{
    D3D12_VIDEO_MOTION_ESTIMATOR_VECTOR_PRECISION_FLAG_NONE = 0,
    D3D12_VIDEO_MOTION_ESTIMATOR_VECTOR_PRECISION_FLAG_QUARTER_PEL = 1,
}
