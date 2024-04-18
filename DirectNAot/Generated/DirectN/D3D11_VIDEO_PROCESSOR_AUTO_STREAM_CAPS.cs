﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ne-d3d11-d3d11_video_processor_auto_stream_caps
public enum D3D11_VIDEO_PROCESSOR_AUTO_STREAM_CAPS
{
    D3D11_VIDEO_PROCESSOR_AUTO_STREAM_CAPS_DENOISE = 1,
    D3D11_VIDEO_PROCESSOR_AUTO_STREAM_CAPS_DERINGING = 2,
    D3D11_VIDEO_PROCESSOR_AUTO_STREAM_CAPS_EDGE_ENHANCEMENT = 4,
    D3D11_VIDEO_PROCESSOR_AUTO_STREAM_CAPS_COLOR_CORRECTION = 8,
    D3D11_VIDEO_PROCESSOR_AUTO_STREAM_CAPS_FLESH_TONE_MAPPING = 16,
    D3D11_VIDEO_PROCESSOR_AUTO_STREAM_CAPS_IMAGE_STABILIZATION = 32,
    D3D11_VIDEO_PROCESSOR_AUTO_STREAM_CAPS_SUPER_RESOLUTION = 64,
    D3D11_VIDEO_PROCESSOR_AUTO_STREAM_CAPS_ANAMORPHIC_SCALING = 128,
}
