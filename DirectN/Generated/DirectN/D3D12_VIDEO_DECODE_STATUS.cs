﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ne-d3d12video-d3d12_video_decode_status
public enum D3D12_VIDEO_DECODE_STATUS
{
    D3D12_VIDEO_DECODE_STATUS_OK = 0,
    D3D12_VIDEO_DECODE_STATUS_CONTINUE = 1,
    D3D12_VIDEO_DECODE_STATUS_CONTINUE_SKIP_DISPLAY = 2,
    D3D12_VIDEO_DECODE_STATUS_RESTART = 3,
    D3D12_VIDEO_DECODE_STATUS_RATE_EXCEEDED = 4,
}
