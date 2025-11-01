﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12sdklayers/ne-d3d12sdklayers-d3d12_debug_device_parameter_type
public enum D3D12_DEBUG_DEVICE_PARAMETER_TYPE
{
    D3D12_DEBUG_DEVICE_PARAMETER_FEATURE_FLAGS = 0,
    D3D12_DEBUG_DEVICE_PARAMETER_GPU_BASED_VALIDATION_SETTINGS = 1,
    D3D12_DEBUG_DEVICE_PARAMETER_GPU_SLOWDOWN_PERFORMANCE_FACTOR = 2,
    D3D12_DEBUG_DEVICE_PARAMETER_BYTECODE_VALIDATION_MODE = 3,
}
