namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KS_VIDEOINFOHEADER
{
    public RECT rcSource;
    public RECT rcTarget;
    public uint dwBitRate;
    public uint dwBitErrorRate;
    public long AvgTimePerFrame;
    public KS_BITMAPINFOHEADER bmiHeader;
}
