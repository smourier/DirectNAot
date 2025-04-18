#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_feature_data_cross_node
public partial struct D3D12_FEATURE_DATA_CROSS_NODE
{
    public D3D12_CROSS_NODE_SHARING_TIER SharingTier;
    public BOOL AtomicShaderInstructions;
}
