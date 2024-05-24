#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mpeg2structs/ns-mpeg2structs-atsc_filter_options
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct ATSC_FILTER_OPTIONS
{
    [MarshalAs(UnmanagedType.U4)]
    public bool fSpecifyEtmId;
    public uint EtmId;
}
