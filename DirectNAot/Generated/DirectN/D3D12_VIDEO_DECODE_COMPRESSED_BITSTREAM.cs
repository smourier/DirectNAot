namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ns-d3d12video-d3d12_video_decode_compressed_bitstream
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_VIDEO_DECODE_COMPRESSED_BITSTREAM
{
    public nint pBuffer;
    public ulong Offset;
    public ulong Size;
}
