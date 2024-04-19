namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ns-d3d12video-d3d12_video_process_input_stream_arguments
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_VIDEO_PROCESS_INPUT_STREAM_ARGUMENTS
{
    public InlineArrayD3D12_VIDEO_PROCESS_INPUT_STREAM2 InputStream;
    public D3D12_VIDEO_PROCESS_TRANSFORM Transform;
    public D3D12_VIDEO_PROCESS_INPUT_STREAM_FLAGS Flags;
    public D3D12_VIDEO_PROCESS_INPUT_STREAM_RATE RateInfo;
    public InlineArrayInt3232 FilterLevels;
    public D3D12_VIDEO_PROCESS_ALPHA_BLENDING AlphaBlending;
}
