#nullable enable
namespace DirectN;

public partial struct DDHAL_UPDATEVPORTDATA
{
    public nint lpDD;
    public nint lpVideoPort;
    public nint lplpDDSurface;
    public nint lplpDDVBISurface;
    public nint lpVideoInfo;
    public uint dwFlags;
    public uint dwNumAutoflip;
    public uint dwNumVBIAutoflip;
    public HRESULT ddRVal;
    public nint UpdateVideoPort;
}
