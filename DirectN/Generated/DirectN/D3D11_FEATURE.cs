﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ne-d3d11-d3d11_feature
public enum D3D11_FEATURE
{
    D3D11_FEATURE_THREADING = 0,
    D3D11_FEATURE_DOUBLES = 1,
    D3D11_FEATURE_FORMAT_SUPPORT = 2,
    D3D11_FEATURE_FORMAT_SUPPORT2 = 3,
    D3D11_FEATURE_D3D10_X_HARDWARE_OPTIONS = 4,
    D3D11_FEATURE_D3D11_OPTIONS = 5,
    D3D11_FEATURE_ARCHITECTURE_INFO = 6,
    D3D11_FEATURE_D3D9_OPTIONS = 7,
    D3D11_FEATURE_SHADER_MIN_PRECISION_SUPPORT = 8,
    D3D11_FEATURE_D3D9_SHADOW_SUPPORT = 9,
    D3D11_FEATURE_D3D11_OPTIONS1 = 10,
    D3D11_FEATURE_D3D9_SIMPLE_INSTANCING_SUPPORT = 11,
    D3D11_FEATURE_MARKER_SUPPORT = 12,
    D3D11_FEATURE_D3D9_OPTIONS1 = 13,
    D3D11_FEATURE_D3D11_OPTIONS2 = 14,
    D3D11_FEATURE_D3D11_OPTIONS3 = 15,
    D3D11_FEATURE_GPU_VIRTUAL_ADDRESS_SUPPORT = 16,
    D3D11_FEATURE_D3D11_OPTIONS4 = 17,
    D3D11_FEATURE_SHADER_CACHE = 18,
    D3D11_FEATURE_D3D11_OPTIONS5 = 19,
    D3D11_FEATURE_DISPLAYABLE = 20,
}