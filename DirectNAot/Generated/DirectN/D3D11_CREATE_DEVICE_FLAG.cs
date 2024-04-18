﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ne-d3d11-d3d11_create_device_flag
public enum D3D11_CREATE_DEVICE_FLAG : uint
{
    D3D11_CREATE_DEVICE_SINGLETHREADED = 1,
    D3D11_CREATE_DEVICE_DEBUG = 2,
    D3D11_CREATE_DEVICE_SWITCH_TO_REF = 4,
    D3D11_CREATE_DEVICE_PREVENT_INTERNAL_THREADING_OPTIMIZATIONS = 8,
    D3D11_CREATE_DEVICE_BGRA_SUPPORT = 32,
    D3D11_CREATE_DEVICE_DEBUGGABLE = 64,
    D3D11_CREATE_DEVICE_PREVENT_ALTERING_LAYER_SETTINGS_FROM_REGISTRY = 128,
    D3D11_CREATE_DEVICE_DISABLE_GPU_TIMEOUT = 256,
    D3D11_CREATE_DEVICE_VIDEO_SUPPORT = 2048,
}
