#nullable enable
namespace DirectN;

public partial struct D3D12_FEATURE_DATA_VIDEO_ENCODER_MOTION_SEARCH
{
    public uint NodeIndex;
    public D3D12_VIDEO_ENCODER_INPUT_MAP_SESSION_INFO SessionInfo;
    public D3D12_VIDEO_ENCODER_FRAME_MOTION_SEARCH_MODE MotionSearchMode;
    public D3D12_VIDEO_ENCODER_INPUT_MAP_SOURCE MapSource;
    public BOOL BidirectionalRefFrameEnabled;
    public D3D12_VIDEO_ENCODER_MOTION_SEARCH_SUPPORT_FLAGS SupportFlags;
    public uint MaxMotionHints;
    public uint MinDeviation;
    public uint MaxDeviation;
    public uint MapSourcePreferenceRanking;
    public D3D12_VIDEO_ENCODER_FRAME_INPUT_MOTION_UNIT_PRECISION_SUPPORT_FLAGS MotionUnitPrecisionSupport;
}
