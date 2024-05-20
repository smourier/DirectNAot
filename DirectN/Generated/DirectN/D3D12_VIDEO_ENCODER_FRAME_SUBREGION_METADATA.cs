#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ns-d3d12video-d3d12_video_encoder_frame_subregion_metadata
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_VIDEO_ENCODER_FRAME_SUBREGION_METADATA
{
    public ulong bSize;
    public ulong bStartOffset;
    public ulong bHeaderSize;
}
