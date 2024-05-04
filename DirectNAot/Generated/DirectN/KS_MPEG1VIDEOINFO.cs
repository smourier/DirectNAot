#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KS_MPEG1VIDEOINFO
{
    public KS_VIDEOINFOHEADER hdr;
    public uint dwStartTimeCode;
    public uint cbSequenceHeader;
    public InlineArrayByte1 bSequenceHeader; // variable-length array placeholder
}
