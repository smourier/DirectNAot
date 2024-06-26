﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ne-d3d12-d3d12_resolve_mode
public enum D3D12_RESOLVE_MODE
{
    D3D12_RESOLVE_MODE_DECOMPRESS = 0,
    D3D12_RESOLVE_MODE_MIN = 1,
    D3D12_RESOLVE_MODE_MAX = 2,
    D3D12_RESOLVE_MODE_AVERAGE = 3,
    D3D12_RESOLVE_MODE_ENCODE_SAMPLER_FEEDBACK = 4,
    D3D12_RESOLVE_MODE_DECODE_SAMPLER_FEEDBACK = 5,
}
