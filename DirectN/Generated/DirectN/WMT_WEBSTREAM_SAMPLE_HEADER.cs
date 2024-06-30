#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/ns-wmsdkidl-wmt_webstream_sample_header
public partial struct WMT_WEBSTREAM_SAMPLE_HEADER
{
    public ushort cbLength;
    public ushort wPart;
    public ushort cTotalParts;
    public ushort wSampleType;
    public InlineArraySystemChar_1 wszURL; // variable-length array placeholder
}
