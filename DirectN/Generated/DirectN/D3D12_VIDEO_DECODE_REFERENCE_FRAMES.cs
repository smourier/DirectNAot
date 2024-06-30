#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ns-d3d12video-d3d12_video_decode_reference_frames
public partial struct D3D12_VIDEO_DECODE_REFERENCE_FRAMES
{
    public uint NumTexture2Ds;
    public nint ppTexture2Ds;
    public nint pSubresources;
    public nint ppHeaps;
}
