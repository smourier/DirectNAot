﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11sdklayers/ne-d3d11sdklayers-d3d11_shader_tracking_options
public enum D3D11_SHADER_TRACKING_OPTIONS
{
    D3D11_SHADER_TRACKING_OPTION_IGNORE = 0,
    D3D11_SHADER_TRACKING_OPTION_TRACK_UNINITIALIZED = 1,
    D3D11_SHADER_TRACKING_OPTION_TRACK_RAW = 2,
    D3D11_SHADER_TRACKING_OPTION_TRACK_WAR = 4,
    D3D11_SHADER_TRACKING_OPTION_TRACK_WAW = 8,
    D3D11_SHADER_TRACKING_OPTION_ALLOW_SAME = 16,
    D3D11_SHADER_TRACKING_OPTION_TRACK_ATOMIC_CONSISTENCY = 32,
    D3D11_SHADER_TRACKING_OPTION_TRACK_RAW_ACROSS_THREADGROUPS = 64,
    D3D11_SHADER_TRACKING_OPTION_TRACK_WAR_ACROSS_THREADGROUPS = 128,
    D3D11_SHADER_TRACKING_OPTION_TRACK_WAW_ACROSS_THREADGROUPS = 256,
    D3D11_SHADER_TRACKING_OPTION_TRACK_ATOMIC_CONSISTENCY_ACROSS_THREADGROUPS = 512,
    D3D11_SHADER_TRACKING_OPTION_UAV_SPECIFIC_FLAGS = 960,
    D3D11_SHADER_TRACKING_OPTION_ALL_HAZARDS = 1006,
    D3D11_SHADER_TRACKING_OPTION_ALL_HAZARDS_ALLOWING_SAME = 1022,
    D3D11_SHADER_TRACKING_OPTION_ALL_OPTIONS = 1023,
}
