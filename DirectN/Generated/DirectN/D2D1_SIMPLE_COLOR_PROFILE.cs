#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1_3/ns-d2d1_3-d2d1_simple_color_profile
public partial struct D2D1_SIMPLE_COLOR_PROFILE
{
    public D2D_POINT_2F redPrimary;
    public D2D_POINT_2F greenPrimary;
    public D2D_POINT_2F bluePrimary;
    public D2D_POINT_2F whitePointXZ;
    public D2D1_GAMMA1 gamma;
}
