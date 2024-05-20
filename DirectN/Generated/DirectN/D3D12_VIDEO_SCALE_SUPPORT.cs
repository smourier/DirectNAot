#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ns-d3d12video-d3d12_video_scale_support
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_VIDEO_SCALE_SUPPORT
{
    public D3D12_VIDEO_SIZE_RANGE OutputSizeRange;
    public D3D12_VIDEO_SCALE_SUPPORT_FLAGS Flags;
}
