#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/amvideo/ns-amvideo-mpeg1videoinfo
[StructLayout(LayoutKind.Sequential)]
public partial struct MPEG1VIDEOINFO
{
    public VIDEOINFOHEADER hdr;
    public uint dwStartTimeCode;
    public uint cbSequenceHeader;
    public InlineArrayByte1 bSequenceHeader; // variable-length array placeholder
}
