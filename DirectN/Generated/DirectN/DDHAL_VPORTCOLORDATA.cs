#nullable enable
namespace DirectN;

public partial struct DDHAL_VPORTCOLORDATA
{
    public nint lpDD;
    public nint lpVideoPort;
    public uint dwFlags;
    public nint lpColorData;
    public HRESULT ddRVal;
    public nint ColorControl;
}
