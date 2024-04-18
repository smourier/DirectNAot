namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1_1/ns-d2d1_1-d2d1_point_description
[StructLayout(LayoutKind.Sequential)]
public partial struct D2D1_POINT_DESCRIPTION
{
    public D2D_POINT_2F point;
    public D2D_POINT_2F unitTangentVector;
    public uint endSegment;
    public uint endFigure;
    public float lengthToEndSegment;
}
