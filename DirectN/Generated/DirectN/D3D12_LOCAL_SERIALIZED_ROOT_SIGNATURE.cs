#nullable enable
namespace DirectN;

public partial struct D3D12_LOCAL_SERIALIZED_ROOT_SIGNATURE : IValueGet<D3D12_SERIALIZED_ROOT_SIGNATURE_DESC>
{
    public D3D12_SERIALIZED_ROOT_SIGNATURE_DESC Desc;
    
    readonly D3D12_SERIALIZED_ROOT_SIGNATURE_DESC IValueGet<D3D12_SERIALIZED_ROOT_SIGNATURE_DESC>.GetValue() => Desc;
    readonly object? IValueGet.GetValue() => Desc;
}
