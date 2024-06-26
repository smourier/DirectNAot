﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ne-d3d12video-d3d12_video_frame_stereo_format
public enum D3D12_VIDEO_FRAME_STEREO_FORMAT
{
    D3D12_VIDEO_FRAME_STEREO_FORMAT_NONE = 0,
    D3D12_VIDEO_FRAME_STEREO_FORMAT_MONO = 1,
    D3D12_VIDEO_FRAME_STEREO_FORMAT_HORIZONTAL = 2,
    D3D12_VIDEO_FRAME_STEREO_FORMAT_VERTICAL = 3,
    D3D12_VIDEO_FRAME_STEREO_FORMAT_SEPARATE = 4,
}
