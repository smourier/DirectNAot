namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/ns-wmsdkidl-wmvideoinfoheader2
[StructLayout(LayoutKind.Sequential)]
public partial struct WMVIDEOINFOHEADER2
{
    public FoundationRECT rcSource;
    public FoundationRECT rcTarget;
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
