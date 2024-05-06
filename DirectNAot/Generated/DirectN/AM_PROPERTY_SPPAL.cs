#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dvdmedia/ns-dvdmedia-am_property_sppal
[StructLayout(LayoutKind.Sequential)]
public partial struct AM_PROPERTY_SPPAL
{
    public InlineArrayAM_DVD_YUV_16 sppal;
}
