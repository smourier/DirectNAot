#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DDHAL_BLTDATA
{
    public nint lpDD;
    public nint lpDDDestSurface;
    public RECTL rDest;
    public nint lpDDSrcSurface;
    public RECTL rSrc;
    public uint dwFlags;
    public uint dwROPFlags;
    public DDBLTFX bltFX;
    public HRESULT ddRVal;
    public nint Blt;
    public BOOL IsClipped;
    public RECTL rOrigDest;
    public RECTL rOrigSrc;
    public uint dwRectCnt;
    public nint prDestRects;
}
