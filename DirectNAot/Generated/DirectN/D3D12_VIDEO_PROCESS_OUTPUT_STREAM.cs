namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ns-d3d12video-d3d12_video_process_output_stream
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_VIDEO_PROCESS_OUTPUT_STREAM
{
    public nint pTexture2D;
    public uint Subresource;
}
