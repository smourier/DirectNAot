#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/ns-wmsdkidl-wmt_buffer_segment
[StructLayout(LayoutKind.Sequential)]
public partial struct WMT_BUFFER_SEGMENT
{
    public nint pBuffer;
    public uint cbOffset;
    public uint cbLength;
}
