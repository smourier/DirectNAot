#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KS_DATAFORMAT_IMAGEINFO
{
    public KSDATAFORMAT DataFormat;
    public KS_BITMAPINFOHEADER ImageInfoHeader;
}
