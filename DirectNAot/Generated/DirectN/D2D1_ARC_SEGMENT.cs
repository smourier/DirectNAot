#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1/ns-d2d1-d2d1_arc_segment
[StructLayout(LayoutKind.Sequential)]
public partial struct D2D1_ARC_SEGMENT
{
    public D2D_POINT_2F point;
    public D2D_SIZE_F size;
    public float rotationAngle;
    public D2D1_SWEEP_DIRECTION sweepDirection;
    public D2D1_ARC_SIZE arcSize;
}
