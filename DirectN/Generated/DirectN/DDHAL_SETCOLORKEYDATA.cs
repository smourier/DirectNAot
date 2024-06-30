#nullable enable
namespace DirectN;

public partial struct DDHAL_SETCOLORKEYDATA
{
    public nint lpDD;
    public nint lpDDSurface;
    public uint dwFlags;
    public DDCOLORKEY ckNew;
    public HRESULT ddRVal;
    public nint SetColorKey;
}
