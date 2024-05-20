#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dvdmedia/ns-dvdmedia-am_dvdcopy_disckey
[StructLayout(LayoutKind.Sequential)]
public partial struct AM_DVDCOPY_DISCKEY
{
    public InlineArrayByte_2048 DiscKey;
}
