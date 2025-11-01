#nullable enable
namespace DirectN;

public partial struct D3D12_FEATURE_DATA_VIDEO_ENCODER_QPMAP_INPUT
{
    public uint NodeIndex;
    public D3D12_VIDEO_ENCODER_INPUT_MAP_SESSION_INFO SessionInfo;
    public D3D12_VIDEO_ENCODER_INPUT_MAP_SOURCE MapSource;
    public BOOL IsSupported;
    public uint MapSourcePreferenceRanking;
    public uint BlockSize;
}
