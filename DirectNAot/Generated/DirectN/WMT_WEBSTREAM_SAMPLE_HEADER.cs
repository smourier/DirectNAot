#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/ns-wmsdkidl-wmt_webstream_sample_header
[StructLayout(LayoutKind.Sequential)]
public partial struct WMT_WEBSTREAM_SAMPLE_HEADER
{
    public ushort cbLength;
    public ushort wPart;
    public ushort cTotalParts;
    public ushort wSampleType;
    public InlineArraySystemChar1 wszURL; // variable-length array placeholder
}
