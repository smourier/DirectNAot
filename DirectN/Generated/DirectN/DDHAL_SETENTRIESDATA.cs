#nullable enable
namespace DirectN;

public partial struct DDHAL_SETENTRIESDATA
{
    public nint lpDD;
    public nint lpDDPalette;
    public uint dwBase;
    public uint dwNumEntries;
    public nint lpEntries;
    public HRESULT ddRVal;
    public nint SetEntries;
}
