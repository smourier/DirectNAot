﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ne-d3d11-d3d11_video_processor_stereo_format
public enum D3D11_VIDEO_PROCESSOR_STEREO_FORMAT
{
    D3D11_VIDEO_PROCESSOR_STEREO_FORMAT_MONO = 0,
    D3D11_VIDEO_PROCESSOR_STEREO_FORMAT_HORIZONTAL = 1,
    D3D11_VIDEO_PROCESSOR_STEREO_FORMAT_VERTICAL = 2,
    D3D11_VIDEO_PROCESSOR_STEREO_FORMAT_SEPARATE = 3,
    D3D11_VIDEO_PROCESSOR_STEREO_FORMAT_MONO_OFFSET = 4,
    D3D11_VIDEO_PROCESSOR_STEREO_FORMAT_ROW_INTERLEAVED = 5,
    D3D11_VIDEO_PROCESSOR_STEREO_FORMAT_COLUMN_INTERLEAVED = 6,
    D3D11_VIDEO_PROCESSOR_STEREO_FORMAT_CHECKERBOARD = 7,
}
