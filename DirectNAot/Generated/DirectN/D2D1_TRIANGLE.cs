#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1/ns-d2d1-d2d1_triangle
[StructLayout(LayoutKind.Sequential)]
public partial struct D2D1_TRIANGLE
{
    public D2D_POINT_2F point1;
    public D2D_POINT_2F point2;
    public D2D_POINT_2F point3;
}
