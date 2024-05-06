#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/ns-wmsdkidl-wmmpeg2videoinfo
[StructLayout(LayoutKind.Sequential)]
public partial struct WMMPEG2VIDEOINFO
{
    public WMVIDEOINFOHEADER2 hdr;
    public uint dwStartTimeCode;
    public uint cbSequenceHeader;
    public uint dwProfile;
    public uint dwLevel;
    public uint dwFlags;
    public InlineArrayUInt32_1 dwSequenceHeader; // variable-length array placeholder
}
