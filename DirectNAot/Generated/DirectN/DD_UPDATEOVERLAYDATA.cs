namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawint/ns-ddrawint-dd_updateoverlaydata
[StructLayout(LayoutKind.Sequential)]
public partial struct DD_UPDATEOVERLAYDATA
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
