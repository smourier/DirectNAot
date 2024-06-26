﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ne-d3d12-d3d12_tile_copy_flags
[Flags]
public enum D3D12_TILE_COPY_FLAGS
{
    D3D12_TILE_COPY_FLAG_NONE = 0,
    D3D12_TILE_COPY_FLAG_NO_HAZARD = 1,
    D3D12_TILE_COPY_FLAG_LINEAR_BUFFER_TO_SWIZZLED_TILED_RESOURCE = 2,
    D3D12_TILE_COPY_FLAG_SWIZZLED_TILED_RESOURCE_TO_LINEAR_BUFFER = 4,
}
