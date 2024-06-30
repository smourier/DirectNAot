#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dvdmedia/ns-dvdmedia-am_dvdcopy_chlgkey
public partial struct AM_DVDCOPY_CHLGKEY
{
    public InlineArrayByte_10 ChlgKey;
    public InlineArrayByte_2 Reserved;
}
