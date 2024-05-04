#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KS_MPEGVIDEOINFO2
{
    public KS_VIDEOINFOHEADER2 hdr;
    public uint dwStartTimeCode;
    public uint cbSequenceHeader;
    public uint dwProfile;
    public uint dwLevel;
    public uint dwFlags;
    public InlineArrayUInt321 bSequenceHeader; // variable-length array placeholder
}
