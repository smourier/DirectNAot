#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dvdmedia/ns-dvdmedia-am_dvdcopy_titlekey
public partial struct AM_DVDCOPY_TITLEKEY
{
    public uint KeyFlags;
    public InlineArrayUInt32_2 Reserved1;
    public InlineArrayByte_6 TitleKey;
    public InlineArrayByte_2 Reserved2;
}
