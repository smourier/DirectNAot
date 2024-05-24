#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/ns-wmsdkidl-wmt_timecode_extension_data
[StructLayout(LayoutKind.Sequential, Pack = 2)]
public partial struct WMT_TIMECODE_EXTENSION_DATA
{
    public ushort wRange;
    public uint dwTimecode;
    public uint dwUserbits;
    public uint dwAmFlags;
}
