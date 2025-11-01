#nullable enable
namespace DirectN;

public partial struct D3D12_VIDEO_ENCODER_MOVEREGION_INFO
{
    public uint NumMoveRegions;
    public nint pMoveRegions;
    public D3D12_VIDEO_ENCODER_FRAME_MOTION_SEARCH_MODE_CONFIG MotionSearchModeConfiguration;
    public uint SourceDPBFrameReference;
    public D3D12_VIDEO_ENCODER_FRAME_INPUT_MOTION_UNIT_PRECISION MotionUnitPrecision;
    public D3D12_VIDEO_ENCODER_MOVEREGION_INFO_FLAGS Flags;
}
