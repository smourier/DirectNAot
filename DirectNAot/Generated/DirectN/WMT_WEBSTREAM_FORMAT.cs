#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/ns-wmsdkidl-wmt_webstream_format
[StructLayout(LayoutKind.Sequential)]
public partial struct WMT_WEBSTREAM_FORMAT
{
    public ushort cbSize;
    public ushort cbSampleHeaderFixedData;
    public ushort wVersion;
    public ushort wReserved;
}
