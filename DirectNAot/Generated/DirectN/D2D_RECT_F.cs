namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dcommon/ns-dcommon-d2d_rect_f
[StructLayout(LayoutKind.Sequential)]
public partial struct D2D_RECT_F
{
    public float left;
    public float top;
    public float right;
    public float bottom;
}
