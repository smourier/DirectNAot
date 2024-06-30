#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dvdmedia/ns-dvdmedia-am_dvdcopy_buskey
public partial struct AM_DVDCOPY_BUSKEY
{
    public InlineArrayByte_5 BusKey;
    public InlineArrayByte_1 Reserved; // variable-length array placeholder
}
