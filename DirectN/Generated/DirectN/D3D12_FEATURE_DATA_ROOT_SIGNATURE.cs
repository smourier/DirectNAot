#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_feature_data_root_signature
public partial struct D3D12_FEATURE_DATA_ROOT_SIGNATURE : IValueGet<D3D_ROOT_SIGNATURE_VERSION>
{
    public D3D_ROOT_SIGNATURE_VERSION HighestVersion;
    
    readonly D3D_ROOT_SIGNATURE_VERSION IValueGet<D3D_ROOT_SIGNATURE_VERSION>.GetValue() => HighestVersion;
    readonly object? IValueGet.GetValue() => HighestVersion;
}
