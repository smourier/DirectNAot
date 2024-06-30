#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1/ns-d2d1-d2d1_radial_gradient_brush_properties
public partial struct D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES
{
    public D2D_POINT_2F center;
    public D2D_POINT_2F gradientOriginOffset;
    public float radiusX;
    public float radiusY;
}
