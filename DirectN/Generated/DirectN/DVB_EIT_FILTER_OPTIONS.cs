#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mpeg2structs/ns-mpeg2structs-dvb_eit_filter_options
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct DVB_EIT_FILTER_OPTIONS
{
    public BOOL fSpecifySegment;
    public byte bSegment;
}
