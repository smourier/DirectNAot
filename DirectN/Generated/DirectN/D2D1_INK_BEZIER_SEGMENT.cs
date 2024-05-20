#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1_3/ns-d2d1_3-d2d1_ink_bezier_segment
[StructLayout(LayoutKind.Sequential)]
public partial struct D2D1_INK_BEZIER_SEGMENT
{
    public D2D1_INK_POINT point1;
    public D2D1_INK_POINT point2;
    public D2D1_INK_POINT point3;
}
