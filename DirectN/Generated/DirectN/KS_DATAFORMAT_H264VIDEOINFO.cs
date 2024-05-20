#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KS_DATAFORMAT_H264VIDEOINFO
{
    public KSDATAFORMAT DataFormat;
    public KS_H264VIDEOINFO H264VideoInfoHeader;
}
