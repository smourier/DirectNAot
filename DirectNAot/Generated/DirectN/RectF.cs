#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1helper/nf-d2d1helper-rectf
[StructLayout(LayoutKind.Sequential)]
public partial struct RectF
{
    public float X;
    public float Y;
    public float Width;
    public float Height;
}
