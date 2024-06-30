#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawint/ns-ddrawint-dd_setentriesdata
public partial struct DD_SETENTRIESDATA
{
    public nint lpDD;
    public nint lpDDPalette;
    public uint dwBase;
    public uint dwNumEntries;
    public nint lpEntries;
    public HRESULT ddRVal;
    public nint SetEntries;
}
