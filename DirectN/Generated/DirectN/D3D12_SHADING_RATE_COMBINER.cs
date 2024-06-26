﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ne-d3d12-d3d12_shading_rate_combiner
public enum D3D12_SHADING_RATE_COMBINER
{
    D3D12_SHADING_RATE_COMBINER_PASSTHROUGH = 0,
    D3D12_SHADING_RATE_COMBINER_OVERRIDE = 1,
    D3D12_SHADING_RATE_COMBINER_MIN = 2,
    D3D12_SHADING_RATE_COMBINER_MAX = 3,
    D3D12_SHADING_RATE_COMBINER_SUM = 4,
}
