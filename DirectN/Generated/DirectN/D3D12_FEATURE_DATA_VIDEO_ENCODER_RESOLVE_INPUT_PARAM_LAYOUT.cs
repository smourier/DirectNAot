#nullable enable
namespace DirectN;

public partial struct D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOLVE_INPUT_PARAM_LAYOUT
{
    public uint NodeIndex;
    public D3D12_VIDEO_ENCODER_INPUT_MAP_SESSION_INFO SessionInfo;
    public D3D12_VIDEO_ENCODER_INPUT_MAP_TYPE MapType;
    public BOOL IsSupported;
    public ulong MaxResolvedBufferAllocationSize;
}
