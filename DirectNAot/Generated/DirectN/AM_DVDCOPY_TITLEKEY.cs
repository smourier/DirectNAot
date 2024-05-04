#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dvdmedia/ns-dvdmedia-am_dvdcopy_titlekey
[StructLayout(LayoutKind.Sequential)]
public partial struct AM_DVDCOPY_TITLEKEY
{
    public uint KeyFlags;
    public InlineArrayUInt322 Reserved1;
    public InlineArrayByte6 TitleKey;
    public InlineArrayByte2 Reserved2;
}
