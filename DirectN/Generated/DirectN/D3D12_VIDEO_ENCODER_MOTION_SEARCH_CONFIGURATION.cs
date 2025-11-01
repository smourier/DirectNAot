#nullable enable
namespace DirectN;

public partial struct D3D12_VIDEO_ENCODER_MOTION_SEARCH_CONFIGURATION
{
    public BOOL Enabled;
    public D3D12_VIDEO_ENCODER_INPUT_MAP_SOURCE MapSource;
    public D3D12_VIDEO_ENCODER_FRAME_MOTION_SEARCH_MODE MotionSearchMode;
    public BOOL BidirectionalRefFrameEnabled;
}
