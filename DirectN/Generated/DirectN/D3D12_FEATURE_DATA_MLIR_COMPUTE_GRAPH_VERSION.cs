#nullable enable
namespace DirectN;

public partial struct D3D12_FEATURE_DATA_MLIR_COMPUTE_GRAPH_VERSION : IValueGet<D3D12_VERSION_NUMBER>
{
    public D3D12_VERSION_NUMBER HighestVersion;
    
    readonly D3D12_VERSION_NUMBER IValueGet<D3D12_VERSION_NUMBER>.GetValue() => HighestVersion;
    readonly object? IValueGet.GetValue() => HighestVersion;
}
