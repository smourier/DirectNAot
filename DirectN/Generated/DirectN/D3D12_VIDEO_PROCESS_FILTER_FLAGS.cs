﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ne-d3d12video-d3d12_video_process_filter_flags
[Flags]
public enum D3D12_VIDEO_PROCESS_FILTER_FLAGS
{
    D3D12_VIDEO_PROCESS_FILTER_FLAG_NONE = 0,
    D3D12_VIDEO_PROCESS_FILTER_FLAG_BRIGHTNESS = 1,
    D3D12_VIDEO_PROCESS_FILTER_FLAG_CONTRAST = 2,
    D3D12_VIDEO_PROCESS_FILTER_FLAG_HUE = 4,
    D3D12_VIDEO_PROCESS_FILTER_FLAG_SATURATION = 8,
    D3D12_VIDEO_PROCESS_FILTER_FLAG_NOISE_REDUCTION = 16,
    D3D12_VIDEO_PROCESS_FILTER_FLAG_EDGE_ENHANCEMENT = 32,
    D3D12_VIDEO_PROCESS_FILTER_FLAG_ANAMORPHIC_SCALING = 64,
    D3D12_VIDEO_PROCESS_FILTER_FLAG_STEREO_ADJUSTMENT = 128,
}
