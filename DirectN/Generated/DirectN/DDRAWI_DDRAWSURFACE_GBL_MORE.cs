#nullable enable
namespace DirectN;

public partial struct DDRAWI_DDRAWSURFACE_GBL_MORE
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public uint dwPhysicalPageTable;
        
        [FieldOffset(0)]
        public nuint fpPhysicalVidMem;
    }
    
    public uint dwSize;
    public _Anonymous_e__Union Anonymous;
    public nint pPageTable;
    public uint cPages;
    public nuint dwSavedDCContext;
    public nuint fpAliasedVidMem;
    public nuint dwDriverReserved;
    public nuint dwHELReserved;
    public uint cPageUnlocks;
    public nuint hKernelSurface;
    public uint dwKernelRefCnt;
    public nint lpColorInfo;
    public nuint fpNTAlias;
    public uint dwContentsStamp;
    public nint lpvUnswappedDriverReserved;
    public nint lpDDRAWReserved2;
    public uint dwDDRAWReserved1;
    public uint dwDDRAWReserved2;
    public nuint fpAliasOfVidMem;
}
