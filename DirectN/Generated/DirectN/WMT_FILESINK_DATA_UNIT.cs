#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/ns-wmsdkidl-wmt_filesink_data_unit
[StructLayout(LayoutKind.Sequential)]
public partial struct WMT_FILESINK_DATA_UNIT
{
    public WMT_BUFFER_SEGMENT packetHeaderBuffer;
    public uint cPayloads;
    public nint pPayloadHeaderBuffers;
    public uint cPayloadDataFragments;
    public nint pPayloadDataFragments;
}
