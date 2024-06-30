#nullable enable
namespace DirectN;

public partial struct KS_MPEG1VIDEOINFO
{
    public KS_VIDEOINFOHEADER hdr;
    public uint dwStartTimeCode;
    public uint cbSequenceHeader;
    public InlineArrayByte_1 bSequenceHeader; // variable-length array placeholder
}
