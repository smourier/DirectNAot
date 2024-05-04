#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ns-d3d12video-d3d12_video_process_output_stream_desc
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC
{
    public DXGI_FORMAT Format;
    public DXGI_COLOR_SPACE_TYPE ColorSpace;
    public D3D12_VIDEO_PROCESS_ALPHA_FILL_MODE AlphaFillMode;
    public uint AlphaFillModeSourceStreamIndex;
    public InlineArraySingle4 BackgroundColor;
    public DXGI_RATIONAL FrameRate;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool EnableStereo;
}
