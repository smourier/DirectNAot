namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mpeg2structs/ns-mpeg2structs-dvb_eit_filter_options
[StructLayout(LayoutKind.Sequential)]
public partial struct DVB_EIT_FILTER_OPTIONS
{
    [MarshalAs(UnmanagedType.U4)]
    public bool fSpecifySegment;
    public byte bSegment;
}
