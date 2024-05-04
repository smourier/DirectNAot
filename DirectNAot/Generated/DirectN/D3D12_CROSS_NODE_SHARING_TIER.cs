#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ne-d3d12-d3d12_cross_node_sharing_tier
public enum D3D12_CROSS_NODE_SHARING_TIER
{
    D3D12_CROSS_NODE_SHARING_TIER_NOT_SUPPORTED = 0,
    D3D12_CROSS_NODE_SHARING_TIER_1_EMULATED = 1,
    D3D12_CROSS_NODE_SHARING_TIER_1 = 2,
    D3D12_CROSS_NODE_SHARING_TIER_2 = 3,
    D3D12_CROSS_NODE_SHARING_TIER_3 = 4,
}
