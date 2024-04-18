namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DDRAWI_DDRAWPALETTE_LCL
{
    public uint lpPalMore;
    public nint lpGbl;
    public nuint dwUnused0;
    public uint dwLocalRefCnt;
    public nint pUnkOuter;
    public nint lpDD_lcl;
    public nuint dwReserved1;
    public nuint dwDDRAWReserved1;
    public nuint dwDDRAWReserved2;
    public nuint dwDDRAWReserved3;
}
