#nullable enable
namespace DirectN;

public partial struct KS_DATARANGE_VIDEO
{
    public KSDATAFORMAT DataRange;
    public BOOL bFixedSizeSamples;
    public BOOL bTemporalCompression;
    public uint StreamDescriptionFlags;
    public uint MemoryAllocationFlags;
    public KS_VIDEO_STREAM_CONFIG_CAPS ConfigCaps;
    public KS_VIDEOINFOHEADER VideoInfoHeader;
}
