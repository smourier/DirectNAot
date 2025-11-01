#nullable enable
namespace DirectN;

public partial struct D3D12_VIDEO_ENCODER_DIRTY_RECT_INFO
{
    public BOOL FullFrameIdentical;
    public D3D12_VIDEO_ENCODER_DIRTY_REGIONS_MAP_VALUES_MODE MapValuesType;
    public uint NumDirtyRects;
    public nint pDirtyRects;
    public uint SourceDPBFrameReference;
}
