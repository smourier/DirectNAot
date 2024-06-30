#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ns-d3d12video-d3d12_video_encoder_level_tier_constraints_hevc
public partial struct D3D12_VIDEO_ENCODER_LEVEL_TIER_CONSTRAINTS_HEVC
{
    public D3D12_VIDEO_ENCODER_LEVELS_HEVC Level;
    public D3D12_VIDEO_ENCODER_TIER_HEVC Tier;
}
