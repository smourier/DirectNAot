#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ne-d3d12-d3d12_tile_range_flags
public enum D3D12_TILE_RANGE_FLAGS
{
    D3D12_TILE_RANGE_FLAG_NONE = 0,
    D3D12_TILE_RANGE_FLAG_NULL = 1,
    D3D12_TILE_RANGE_FLAG_SKIP = 2,
    D3D12_TILE_RANGE_FLAG_REUSE_SINGLE_TILE = 4,
}
