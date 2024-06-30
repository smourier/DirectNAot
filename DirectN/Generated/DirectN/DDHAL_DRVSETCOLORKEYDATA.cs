#nullable enable
namespace DirectN;

public partial struct DDHAL_DRVSETCOLORKEYDATA
{
    public nint lpDDSurface;
    public uint dwFlags;
    public DDCOLORKEY ckNew;
    public HRESULT ddRVal;
    public nint SetColorKey;
}
