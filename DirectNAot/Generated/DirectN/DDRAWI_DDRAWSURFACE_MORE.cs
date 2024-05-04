#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DDRAWI_DDRAWSURFACE_MORE
{
    public uint dwSize;
    public nint lpIUnknowns;
    public nint lpDD_lcl;
    public uint dwPageLockCount;
    public uint dwBytesAllocated;
    public nint lpDD_int;
    public uint dwMipMapCount;
    public nint lpDDIClipper;
    public nint lpHeapAliasInfo;
    public uint dwOverlayFlags;
    public nint rgjunc;
    public nint lpVideoPort;
    public nint lpddOverlayFX;
    public DDSCAPSEX ddsCapsEx;
    public uint dwTextureStage;
    public nint lpDDRAWReserved;
    public nint lpDDRAWReserved2;
    public nint lpDDrawReserved3;
    public uint dwDDrawReserved4;
    public nint lpDDrawReserved5;
    public nint lpGammaRamp;
    public nint lpOriginalGammaRamp;
    public nint lpDDrawReserved6;
    public uint dwSurfaceHandle;
    public InlineArrayUInt322 qwDDrawReserved8;
    public nint lpDDrawReserved9;
    public uint cSurfaces;
    public nint pCreatedDDSurfaceDesc2;
    public nint slist;
    public uint dwFVF;
    public nint lpVB;
}
