namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KS_DATAFORMAT_VIDEOINFOHEADER
{
    public KSDATAFORMAT DataFormat;
    public KS_VIDEOINFOHEADER VideoInfoHeader;
}
