#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ns-d3d12video-d3d12_video_motion_estimator_output
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_VIDEO_MOTION_ESTIMATOR_OUTPUT
{
    public nint pMotionVectorHeap;
}
