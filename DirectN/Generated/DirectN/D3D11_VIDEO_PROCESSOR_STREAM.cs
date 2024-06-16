#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ns-d3d11-d3d11_video_processor_stream
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D11_VIDEO_PROCESSOR_STREAM
{
    public BOOL Enable;
    public uint OutputIndex;
    public uint InputFrameOrField;
    public uint PastFrames;
    public uint FutureFrames;
    public nint ppPastSurfaces;
    public nint pInputSurface;
    public nint ppFutureSurfaces;
    public nint ppPastSurfacesRight;
    public nint pInputSurfaceRight;
    public nint ppFutureSurfacesRight;
}
