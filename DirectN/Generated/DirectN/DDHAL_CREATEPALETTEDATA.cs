#nullable enable
namespace DirectN;

public partial struct DDHAL_CREATEPALETTEDATA
{
    public nint lpDD;
    public nint lpDDPalette;
    public nint lpColorTable;
    public HRESULT ddRVal;
    public nint CreatePalette;
    public BOOL is_excl;
}
