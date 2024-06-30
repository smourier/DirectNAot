#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ns-d3d12video-d3d12_resolve_video_motion_vector_heap_input
public partial struct D3D12_RESOLVE_VIDEO_MOTION_VECTOR_HEAP_INPUT
{
    public nint pMotionVectorHeap;
    public uint PixelWidth;
    public uint PixelHeight;
}
