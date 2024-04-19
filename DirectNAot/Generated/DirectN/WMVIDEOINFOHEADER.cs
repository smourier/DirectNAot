namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/ns-wmsdkidl-wmvideoinfoheader
[StructLayout(LayoutKind.Sequential)]
public partial struct WMVIDEOINFOHEADER
{
    public FoundationRECT rcSource;
    public FoundationRECT rcTarget;
    public uint dwBitRate;
    public uint dwBitErrorRate;
    public long AvgTimePerFrame;
    public BITMAPINFOHEADER bmiHeader;
}
