#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/ns-wmsdkidl-wmvideoinfoheader2
public partial struct WMVIDEOINFOHEADER2
{
    public RECT rcSource;
    public RECT rcTarget;
    public uint dwBitRate;
    public uint dwBitErrorRate;
    public long AvgTimePerFrame;
    public uint dwInterlaceFlags;
    public uint dwCopyProtectFlags;
    public uint dwPictAspectRatioX;
    public uint dwPictAspectRatioY;
    public uint dwReserved1;
    public uint dwReserved2;
    public BITMAPINFOHEADER bmiHeader;
}
