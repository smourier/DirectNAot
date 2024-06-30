#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/amvideo/ns-amvideo-videoinfoheader
public partial struct VIDEOINFOHEADER
{
    public RECT rcSource;
    public RECT rcTarget;
    public uint dwBitRate;
    public uint dwBitErrorRate;
    public long AvgTimePerFrame;
    public BITMAPINFOHEADER bmiHeader;
}
