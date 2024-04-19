namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ns-d3d12video-d3d12_video_process_output_stream_arguments
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_VIDEO_PROCESS_OUTPUT_STREAM_ARGUMENTS
{
    public InlineArrayD3D12_VIDEO_PROCESS_OUTPUT_STREAM2 OutputStream;
    public FoundationRECT TargetRectangle;
}
