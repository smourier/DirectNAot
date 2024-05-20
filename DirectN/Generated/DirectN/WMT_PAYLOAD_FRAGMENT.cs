#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/ns-wmsdkidl-wmt_payload_fragment
[StructLayout(LayoutKind.Sequential)]
public partial struct WMT_PAYLOAD_FRAGMENT
{
    public uint dwPayloadIndex;
    public WMT_BUFFER_SEGMENT segmentData;
}
