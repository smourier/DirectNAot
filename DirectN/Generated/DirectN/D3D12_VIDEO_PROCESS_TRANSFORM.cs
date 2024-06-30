#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ns-d3d12video-d3d12_video_process_transform
public partial struct D3D12_VIDEO_PROCESS_TRANSFORM
{
    public RECT SourceRectangle;
    public RECT DestinationRectangle;
    public D3D12_VIDEO_PROCESS_ORIENTATION Orientation;
}
