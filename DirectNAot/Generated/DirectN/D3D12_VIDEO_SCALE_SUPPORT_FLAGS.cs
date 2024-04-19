﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ne-d3d12video-d3d12_video_scale_support_flags
public enum D3D12_VIDEO_SCALE_SUPPORT_FLAGS
{
    D3D12_VIDEO_SCALE_SUPPORT_FLAG_NONE = 0,
    D3D12_VIDEO_SCALE_SUPPORT_FLAG_POW2_ONLY = 1,
    D3D12_VIDEO_SCALE_SUPPORT_FLAG_EVEN_DIMENSIONS_ONLY = 2,
}
