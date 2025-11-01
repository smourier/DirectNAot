#nullable enable
namespace DirectN;

public partial struct D3D11_FEATURE_DATA_D3D11_OPTIONS6 : IValueGet<D3D11_SHADER_ACCESS_RESTRICTED_RESOURCE_TIER>
{
    public D3D11_SHADER_ACCESS_RESTRICTED_RESOURCE_TIER ShaderAccessRestrictedResourceTier;
    
    readonly D3D11_SHADER_ACCESS_RESTRICTED_RESOURCE_TIER IValueGet<D3D11_SHADER_ACCESS_RESTRICTED_RESOURCE_TIER>.GetValue() => ShaderAccessRestrictedResourceTier;
    readonly object? IValueGet.GetValue() => ShaderAccessRestrictedResourceTier;
}
