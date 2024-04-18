﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ne-d3d11-d3d11_video_processor_device_caps
public enum D3D11_VIDEO_PROCESSOR_DEVICE_CAPS
{
    D3D11_VIDEO_PROCESSOR_DEVICE_CAPS_LINEAR_SPACE = 1,
    D3D11_VIDEO_PROCESSOR_DEVICE_CAPS_xvYCC = 2,
    D3D11_VIDEO_PROCESSOR_DEVICE_CAPS_RGB_RANGE_CONVERSION = 4,
    D3D11_VIDEO_PROCESSOR_DEVICE_CAPS_YCbCr_MATRIX_CONVERSION = 8,
    D3D11_VIDEO_PROCESSOR_DEVICE_CAPS_NOMINAL_RANGE = 16,
}
