﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ne-d3d12-d3d12_render_pass_ending_access_type
public enum D3D12_RENDER_PASS_ENDING_ACCESS_TYPE
{
    D3D12_RENDER_PASS_ENDING_ACCESS_TYPE_DISCARD = 0,
    D3D12_RENDER_PASS_ENDING_ACCESS_TYPE_PRESERVE = 1,
    D3D12_RENDER_PASS_ENDING_ACCESS_TYPE_RESOLVE = 2,
    D3D12_RENDER_PASS_ENDING_ACCESS_TYPE_NO_ACCESS = 3,
    D3D12_RENDER_PASS_ENDING_ACCESS_TYPE_PRESERVE_LOCAL_RENDER = 4,
    D3D12_RENDER_PASS_ENDING_ACCESS_TYPE_PRESERVE_LOCAL_SRV = 5,
    D3D12_RENDER_PASS_ENDING_ACCESS_TYPE_PRESERVE_LOCAL_UAV = 6,
}
