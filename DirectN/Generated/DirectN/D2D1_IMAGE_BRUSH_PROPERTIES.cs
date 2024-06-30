#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1_1/ns-d2d1_1-d2d1_image_brush_properties
public partial struct D2D1_IMAGE_BRUSH_PROPERTIES
{
    public D2D_RECT_F sourceRectangle;
    public D2D1_EXTEND_MODE extendModeX;
    public D2D1_EXTEND_MODE extendModeY;
    public D2D1_INTERPOLATION_MODE interpolationMode;
}
