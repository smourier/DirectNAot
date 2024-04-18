namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1/ns-d2d1-d2d1_ellipse
[StructLayout(LayoutKind.Sequential)]
public partial struct D2D1_ELLIPSE
{
    public D2D_POINT_2F point;
    public float radiusX;
    public float radiusY;
}
