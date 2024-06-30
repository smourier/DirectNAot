#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dvdmedia/ns-dvdmedia-mpeg2videoinfo
public partial struct MPEG2VIDEOINFO
{
    public VIDEOINFOHEADER2 hdr;
    public uint dwStartTimeCode;
    public uint cbSequenceHeader;
    public uint dwProfile;
    public uint dwLevel;
    public MPEG2VIDEOINFO_FLAGS dwFlags;
    public InlineArrayUInt32_1 dwSequenceHeader; // variable-length array placeholder
}
