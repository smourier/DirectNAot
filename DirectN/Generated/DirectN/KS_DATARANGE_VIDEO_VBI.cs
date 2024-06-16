#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KS_DATARANGE_VIDEO_VBI
{
    public KSDATAFORMAT DataRange;
    public BOOL bFixedSizeSamples;
    public BOOL bTemporalCompression;
    public uint StreamDescriptionFlags;
    public uint MemoryAllocationFlags;
    public KS_VIDEO_STREAM_CONFIG_CAPS ConfigCaps;
    public KS_VBIINFOHEADER VBIInfoHeader;
}
