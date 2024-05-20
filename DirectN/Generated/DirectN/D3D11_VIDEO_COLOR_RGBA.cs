#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ns-d3d11-d3d11_video_color_rgba
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D11_VIDEO_COLOR_RGBA
{
    public float R;
    public float G;
    public float B;
    public float A;
}
