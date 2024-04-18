namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1/ns-d2d1-d2d1_bitmap_brush_properties
[StructLayout(LayoutKind.Sequential)]
public partial struct D2D1_BITMAP_BRUSH_PROPERTIES
{
    public D2D1_EXTEND_MODE extendModeX;
    public D2D1_EXTEND_MODE extendModeY;
    public D2D1_BITMAP_INTERPOLATION_MODE interpolationMode;
}
