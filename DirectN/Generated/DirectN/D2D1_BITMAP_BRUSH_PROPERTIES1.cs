#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1_1/ns-d2d1_1-d2d1_bitmap_brush_properties1
[StructLayout(LayoutKind.Sequential)]
public partial struct D2D1_BITMAP_BRUSH_PROPERTIES1
{
    public D2D1_EXTEND_MODE extendModeX;
    public D2D1_EXTEND_MODE extendModeY;
    public D2D1_INTERPOLATION_MODE interpolationMode;
}
