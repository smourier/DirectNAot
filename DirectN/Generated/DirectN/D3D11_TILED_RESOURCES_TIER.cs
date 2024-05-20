﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ne-d3d11-d3d11_tiled_resources_tier
public enum D3D11_TILED_RESOURCES_TIER
{
    D3D11_TILED_RESOURCES_NOT_SUPPORTED = 0,
    D3D11_TILED_RESOURCES_TIER_1 = 1,
    D3D11_TILED_RESOURCES_TIER_2 = 2,
    D3D11_TILED_RESOURCES_TIER_3 = 3,
}
