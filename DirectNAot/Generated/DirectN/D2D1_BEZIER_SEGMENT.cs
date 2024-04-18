namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1/ns-d2d1-d2d1_bezier_segment
[StructLayout(LayoutKind.Sequential)]
public partial struct D2D1_BEZIER_SEGMENT
{
    public D2D_POINT_2F point1;
    public D2D_POINT_2F point2;
    public D2D_POINT_2F point3;
}
