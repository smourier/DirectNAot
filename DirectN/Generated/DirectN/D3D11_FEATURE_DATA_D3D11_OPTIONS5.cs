#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ns-d3d11-d3d11_feature_data_d3d11_options5
public partial struct D3D11_FEATURE_DATA_D3D11_OPTIONS5 : IValueGet<D3D11_SHARED_RESOURCE_TIER>
{
    public D3D11_SHARED_RESOURCE_TIER SharedResourceTier;
    
    readonly D3D11_SHARED_RESOURCE_TIER IValueGet<D3D11_SHARED_RESOURCE_TIER>.GetValue() => SharedResourceTier;
    readonly object? IValueGet.GetValue() => SharedResourceTier;
}
