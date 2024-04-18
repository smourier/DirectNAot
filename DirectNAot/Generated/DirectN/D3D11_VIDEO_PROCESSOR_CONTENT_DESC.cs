namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ns-d3d11-d3d11_video_processor_content_desc
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D11_VIDEO_PROCESSOR_CONTENT_DESC
{
    public D3D11_VIDEO_FRAME_FORMAT InputFrameFormat;
    public DXGI_RATIONAL InputFrameRate;
    public uint InputWidth;
    public uint InputHeight;
    public DXGI_RATIONAL OutputFrameRate;
    public uint OutputWidth;
    public uint OutputHeight;
    public D3D11_VIDEO_USAGE Usage;
}
