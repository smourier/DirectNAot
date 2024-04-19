namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ns-d3d12video-d3d12_video_decode_output_histogram
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_VIDEO_DECODE_OUTPUT_HISTOGRAM
{
    public ulong Offset;
    public nint pBuffer;
}
