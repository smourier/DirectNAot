namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ns-d3d12video-d3d12_video_decode_configuration
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_VIDEO_DECODE_CONFIGURATION
{
    public Guid DecodeProfile;
    public D3D12_BITSTREAM_ENCRYPTION_TYPE BitstreamEncryption;
    public D3D12_VIDEO_FRAME_CODED_INTERLACE_TYPE InterlaceType;
}
