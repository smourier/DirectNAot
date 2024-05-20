#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ne-d3d12video-d3d12_video_decode_tier
public enum D3D12_VIDEO_DECODE_TIER
{
    D3D12_VIDEO_DECODE_TIER_NOT_SUPPORTED = 0,
    D3D12_VIDEO_DECODE_TIER_1 = 1,
    D3D12_VIDEO_DECODE_TIER_2 = 2,
    D3D12_VIDEO_DECODE_TIER_3 = 3,
}
