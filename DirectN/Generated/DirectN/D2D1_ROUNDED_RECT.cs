#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1/ns-d2d1-d2d1_rounded_rect
public partial struct D2D1_ROUNDED_RECT
{
    public D2D_RECT_F rect;
    public float radiusX;
    public float radiusY;
}
