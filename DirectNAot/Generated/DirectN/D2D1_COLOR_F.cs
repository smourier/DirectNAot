#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/Direct2D/d2d1-color-f
[StructLayout(LayoutKind.Sequential)]
public partial struct D2D1_COLOR_F
{
    public float r;
    public float g;
    public float b;
    public float a;
}
