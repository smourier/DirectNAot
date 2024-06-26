﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ne-d3d12video-d3d12_video_encoder_rate_control_mode
public enum D3D12_VIDEO_ENCODER_RATE_CONTROL_MODE
{
    D3D12_VIDEO_ENCODER_RATE_CONTROL_MODE_ABSOLUTE_QP_MAP = 0,
    D3D12_VIDEO_ENCODER_RATE_CONTROL_MODE_CQP = 1,
    D3D12_VIDEO_ENCODER_RATE_CONTROL_MODE_CBR = 2,
    D3D12_VIDEO_ENCODER_RATE_CONTROL_MODE_VBR = 3,
    D3D12_VIDEO_ENCODER_RATE_CONTROL_MODE_QVBR = 4,
}
