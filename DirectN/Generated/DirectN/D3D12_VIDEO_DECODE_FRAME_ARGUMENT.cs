#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ns-d3d12video-d3d12_video_decode_frame_argument
public partial struct D3D12_VIDEO_DECODE_FRAME_ARGUMENT
{
    public D3D12_VIDEO_DECODE_ARGUMENT_TYPE Type;
    public uint Size;
    public nint pData;
}
