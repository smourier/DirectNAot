#nullable enable
namespace DirectN;

public partial struct D3D12_PRIMITIVE_TOPOLOGY_DESC : IValueGet<D3D12_PRIMITIVE_TOPOLOGY_TYPE>
{
    public D3D12_PRIMITIVE_TOPOLOGY_TYPE PrimitiveTopology;
    
    readonly D3D12_PRIMITIVE_TOPOLOGY_TYPE IValueGet<D3D12_PRIMITIVE_TOPOLOGY_TYPE>.GetValue() => PrimitiveTopology;
    readonly object? IValueGet.GetValue() => PrimitiveTopology;
}
