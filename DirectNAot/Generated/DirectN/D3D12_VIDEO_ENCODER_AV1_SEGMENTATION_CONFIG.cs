#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_CONFIG
{
    public ulong UpdateMap;
    public ulong TemporalUpdate;
    public ulong UpdateData;
    public ulong NumSegments;
    public InlineArrayD3D12_VIDEO_ENCODER_AV1_SEGMENT_DATA_8 SegmentsData;
}
