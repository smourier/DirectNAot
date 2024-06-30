#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1_1/ns-d2d1_1-d2d1_stroke_style_properties1
public partial struct D2D1_STROKE_STYLE_PROPERTIES1
{
    public D2D1_CAP_STYLE startCap;
    public D2D1_CAP_STYLE endCap;
    public D2D1_CAP_STYLE dashCap;
    public D2D1_LINE_JOIN lineJoin;
    public float miterLimit;
    public D2D1_DASH_STYLE dashStyle;
    public float dashOffset;
    public D2D1_STROKE_TRANSFORM_TYPE transformType;
}
