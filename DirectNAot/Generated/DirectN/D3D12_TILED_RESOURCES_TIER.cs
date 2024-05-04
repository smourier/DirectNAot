#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ne-d3d12-d3d12_tiled_resources_tier
public enum D3D12_TILED_RESOURCES_TIER
{
    D3D12_TILED_RESOURCES_TIER_NOT_SUPPORTED = 0,
    D3D12_TILED_RESOURCES_TIER_1 = 1,
    D3D12_TILED_RESOURCES_TIER_2 = 2,
    D3D12_TILED_RESOURCES_TIER_3 = 3,
    D3D12_TILED_RESOURCES_TIER_4 = 4,
}
