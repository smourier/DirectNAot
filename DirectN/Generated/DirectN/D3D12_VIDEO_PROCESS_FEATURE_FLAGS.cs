﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ne-d3d12video-d3d12_video_process_feature_flags
[Flags]
public enum D3D12_VIDEO_PROCESS_FEATURE_FLAGS
{
    D3D12_VIDEO_PROCESS_FEATURE_FLAG_NONE = 0,
    D3D12_VIDEO_PROCESS_FEATURE_FLAG_ALPHA_FILL = 1,
    D3D12_VIDEO_PROCESS_FEATURE_FLAG_LUMA_KEY = 2,
    D3D12_VIDEO_PROCESS_FEATURE_FLAG_STEREO = 4,
    D3D12_VIDEO_PROCESS_FEATURE_FLAG_ROTATION = 8,
    D3D12_VIDEO_PROCESS_FEATURE_FLAG_FLIP = 16,
    D3D12_VIDEO_PROCESS_FEATURE_FLAG_ALPHA_BLENDING = 32,
    D3D12_VIDEO_PROCESS_FEATURE_FLAG_PIXEL_ASPECT_RATIO = 64,
}
