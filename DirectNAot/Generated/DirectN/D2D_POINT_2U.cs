#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dcommon/ns-dcommon-d2d_point_2u
[StructLayout(LayoutKind.Sequential)]
public partial struct D2D_POINT_2U
{
    public uint x;
    public uint y;
}
