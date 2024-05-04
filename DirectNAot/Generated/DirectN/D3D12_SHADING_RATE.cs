﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ne-d3d12-d3d12_shading_rate
public enum D3D12_SHADING_RATE
{
    D3D12_SHADING_RATE_1X1 = 0,
    D3D12_SHADING_RATE_1X2 = 1,
    D3D12_SHADING_RATE_2X1 = 4,
    D3D12_SHADING_RATE_2X2 = 5,
    D3D12_SHADING_RATE_2X4 = 6,
    D3D12_SHADING_RATE_4X2 = 9,
    D3D12_SHADING_RATE_4X4 = 10,
}
