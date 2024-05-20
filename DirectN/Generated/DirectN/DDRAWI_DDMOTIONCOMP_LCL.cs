#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DDRAWI_DDMOTIONCOMP_LCL
{
    public nint lpDD;
    public Guid guid;
    public uint dwUncompWidth;
    public uint dwUncompHeight;
    public DDPIXELFORMAT ddUncompPixelFormat;
    public uint dwInternalFlags;
    public uint dwRefCnt;
    public uint dwProcessId;
    public HANDLE hMoComp;
    public uint dwDriverReserved1;
    public uint dwDriverReserved2;
    public uint dwDriverReserved3;
    public nint lpDriverReserved1;
    public nint lpDriverReserved2;
    public nint lpDriverReserved3;
}
