#nullable enable
namespace DirectN;

public partial struct D3D12_FEATURE_DATA_VIDEO_ENCODER_DIRTY_REGIONS
{
    public uint NodeIndex;
    public D3D12_VIDEO_ENCODER_INPUT_MAP_SESSION_INFO SessionInfo;
    public D3D12_VIDEO_ENCODER_INPUT_MAP_SOURCE MapSource;
    public D3D12_VIDEO_ENCODER_DIRTY_REGIONS_MAP_VALUES_MODE MapValuesType;
    public D3D12_VIDEO_ENCODER_DIRTY_REGIONS_SUPPORT_FLAGS SupportFlags;
    public uint MapSourcePreferenceRanking;
}
