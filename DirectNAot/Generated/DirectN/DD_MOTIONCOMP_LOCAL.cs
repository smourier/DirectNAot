#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawint/ns-ddrawint-dd_motioncomp_local
[StructLayout(LayoutKind.Sequential)]
public partial struct DD_MOTIONCOMP_LOCAL
{
    public nint lpDD;
    public Guid guid;
    public uint dwUncompWidth;
    public uint dwUncompHeight;
    public DDPIXELFORMAT ddUncompPixelFormat;
    public uint dwDriverReserved1;
    public uint dwDriverReserved2;
    public uint dwDriverReserved3;
    public nint lpDriverReserved1;
    public nint lpDriverReserved2;
    public nint lpDriverReserved3;
}
