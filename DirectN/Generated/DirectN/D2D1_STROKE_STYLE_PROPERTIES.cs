#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1/ns-d2d1-d2d1_stroke_style_properties
[StructLayout(LayoutKind.Sequential)]
public partial struct D2D1_STROKE_STYLE_PROPERTIES
{
    public D2D1_CAP_STYLE startCap;
    public D2D1_CAP_STYLE endCap;
    public D2D1_CAP_STYLE dashCap;
    public D2D1_LINE_JOIN lineJoin;
    public float miterLimit;
    public D2D1_DASH_STYLE dashStyle;
    public float dashOffset;
}
