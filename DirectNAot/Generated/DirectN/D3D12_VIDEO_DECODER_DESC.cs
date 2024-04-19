namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ns-d3d12video-d3d12_video_decoder_desc
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_VIDEO_DECODER_DESC
{
    public uint NodeMask;
    public D3D12_VIDEO_DECODE_CONFIGURATION Configuration;
}
