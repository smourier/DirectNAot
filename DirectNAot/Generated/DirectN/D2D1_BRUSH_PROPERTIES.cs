#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1/ns-d2d1-d2d1_brush_properties
[StructLayout(LayoutKind.Sequential)]
public partial struct D2D1_BRUSH_PROPERTIES
{
    public float opacity;
    public D2D_MATRIX_3X2_F transform;
}
