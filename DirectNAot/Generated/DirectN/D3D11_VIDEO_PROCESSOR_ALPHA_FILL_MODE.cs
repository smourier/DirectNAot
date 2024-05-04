﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ne-d3d11-d3d11_video_processor_alpha_fill_mode
public enum D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE
{
    D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE_OPAQUE = 0,
    D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE_BACKGROUND = 1,
    D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE_DESTINATION = 2,
    D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE_SOURCE_STREAM = 3,
}
