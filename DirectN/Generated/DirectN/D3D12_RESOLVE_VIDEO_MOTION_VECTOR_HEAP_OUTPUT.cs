#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ns-d3d12video-d3d12_resolve_video_motion_vector_heap_output
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_RESOLVE_VIDEO_MOTION_VECTOR_HEAP_OUTPUT
{
    public nint pMotionVectorTexture2D;
    public D3D12_RESOURCE_COORDINATE MotionVectorCoordinate;
}
