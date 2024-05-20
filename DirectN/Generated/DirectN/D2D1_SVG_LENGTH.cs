#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1svg/ns-d2d1svg-d2d1_svg_length
[StructLayout(LayoutKind.Sequential)]
public partial struct D2D1_SVG_LENGTH
{
    public float value;
    public D2D1_SVG_LENGTH_UNITS units;
}
