#nullable enable
namespace DirectN;

public partial struct DDHAL_SETOVERLAYPOSITIONDATA
{
    public nint lpDD;
    public nint lpDDSrcSurface;
    public nint lpDDDestSurface;
    public int lXPos;
    public int lYPos;
    public HRESULT ddRVal;
    public nint SetOverlayPosition;
}
