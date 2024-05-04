#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11_1/ns-d3d11_1-d3d11_video_sample_desc
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D11_VIDEO_SAMPLE_DESC
{
    public uint Width;
    public uint Height;
    public DXGI_FORMAT Format;
    public DXGI_COLOR_SPACE_TYPE ColorSpace;
}
