#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1_1/ns-d2d1_1-d2d1_mapped_rect
[StructLayout(LayoutKind.Sequential)]
public partial struct D2D1_MAPPED_RECT
{
    public uint pitch;
    public nint bits;
}
