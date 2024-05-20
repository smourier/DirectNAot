#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DDRAWI_DDRAWCLIPPER_LCL
{
    public uint lpClipMore;
    public nint lpGbl;
    public nint lpDD_lcl;
    public uint dwLocalRefCnt;
    public nint pUnkOuter;
    public nint lpDD_int;
    public nuint dwReserved1;
    public nint pAddrefedThisOwner;
}
