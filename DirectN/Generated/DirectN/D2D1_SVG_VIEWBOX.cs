#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1svg/ns-d2d1svg-d2d1_svg_viewbox
[StructLayout(LayoutKind.Sequential)]
public partial struct D2D1_SVG_VIEWBOX
{
    public float x;
    public float y;
    public float width;
    public float height;
}
