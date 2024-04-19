namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KS_DATARANGE_ANALOGVIDEO
{
    public KSDATAFORMAT DataRange;
    public KS_ANALOGVIDEOINFO AnalogVideoInfo;
}
