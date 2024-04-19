namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KS_VBI_FRAME_INFO
{
    public uint ExtendedHeaderSize;
    public uint dwFrameFlags;
    public long PictureNumber;
    public long DropCount;
    public uint dwSamplingFrequency;
    public KS_TVTUNER_CHANGE_INFO TvTunerChangeInfo;
    public KS_VBIINFOHEADER VBIInfoHeader;
}
