namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DDHAL_UPDATEOVERLAYDATA
{
    public nint lpDD;
    public nint lpDDDestSurface;
    public RECTL rDest;
    public nint lpDDSrcSurface;
    public RECTL rSrc;
    public uint dwFlags;
    public DDOVERLAYFX overlayFX;
    public HRESULT ddRVal;
    public nint UpdateOverlay;
}
