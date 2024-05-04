#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KS_DATARANGE_IMAGE
{
    public KSDATAFORMAT DataRange;
    public KS_VIDEO_STREAM_CONFIG_CAPS ConfigCaps;
    public KS_BITMAPINFOHEADER ImageInfoHeader;
}
