#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1svg/ns-d2d1svg-d2d1_svg_preserve_aspect_ratio
public partial struct D2D1_SVG_PRESERVE_ASPECT_RATIO
{
    public BOOL defer;
    public D2D1_SVG_ASPECT_ALIGN align;
    public D2D1_SVG_ASPECT_SCALING meetOrSlice;
}
