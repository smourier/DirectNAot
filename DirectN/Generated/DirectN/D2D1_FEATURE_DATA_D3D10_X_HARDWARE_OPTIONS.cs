﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/ns-d2d1effectauthor-d2d1_feature_data_d3d10_x_hardware_options
[StructLayout(LayoutKind.Sequential)]
public partial struct D2D1_FEATURE_DATA_D3D10_X_HARDWARE_OPTIONS
{
    [MarshalAs(UnmanagedType.U4)]
    public bool computeShaders_Plus_RawAndStructuredBuffers_Via_Shader_4_x;
}
