#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1/ns-d2d1-d2d1_gradient_stop
public partial struct D2D1_GRADIENT_STOP
{
    public float position;
    public D3DCOLORVALUE color;
}
