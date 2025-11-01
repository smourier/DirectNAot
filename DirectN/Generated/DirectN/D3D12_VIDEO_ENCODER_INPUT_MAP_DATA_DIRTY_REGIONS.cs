#nullable enable
namespace DirectN;

public partial struct D3D12_VIDEO_ENCODER_INPUT_MAP_DATA_DIRTY_REGIONS
{
    public BOOL FullFrameIdentical;
    public D3D12_VIDEO_ENCODER_DIRTY_REGIONS_MAP_VALUES_MODE MapValuesType;
    public nint pDirtyRegionsMap;
    public uint SourceDPBFrameReference;
}
