namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1svg/ne-d2d1svg-d2d1_svg_paint_type
public enum D2D1_SVG_PAINT_TYPE
{
    D2D1_SVG_PAINT_TYPE_NONE = 0,
    D2D1_SVG_PAINT_TYPE_COLOR = 1,
    D2D1_SVG_PAINT_TYPE_CURRENT_COLOR = 2,
    D2D1_SVG_PAINT_TYPE_URI = 3,
    D2D1_SVG_PAINT_TYPE_URI_NONE = 4,
    D2D1_SVG_PAINT_TYPE_URI_COLOR = 5,
    D2D1_SVG_PAINT_TYPE_URI_CURRENT_COLOR = 6,
}
