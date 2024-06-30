#nullable enable
namespace DirectN;

public partial struct DDHAL_GETFLIPSTATUSDATA
{
    public nint lpDD;
    public nint lpDDSurface;
    public uint dwFlags;
    public HRESULT ddRVal;
    public nint GetFlipStatus;
}
