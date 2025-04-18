#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawint/ns-ddrawint-dd_createpalettedata
public partial struct DD_CREATEPALETTEDATA
{
    public nint lpDD;
    public nint lpDDPalette;
    public nint lpColorTable;
    public HRESULT ddRVal;
    public nint CreatePalette;
    public BOOL is_excl;
}
