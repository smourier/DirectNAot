#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_feature_data_shader_cache
public partial struct D3D12_FEATURE_DATA_SHADER_CACHE : IValueGet<D3D12_SHADER_CACHE_SUPPORT_FLAGS>
{
    public D3D12_SHADER_CACHE_SUPPORT_FLAGS SupportFlags;
    
    readonly D3D12_SHADER_CACHE_SUPPORT_FLAGS IValueGet<D3D12_SHADER_CACHE_SUPPORT_FLAGS>.GetValue() => SupportFlags;
    readonly object? IValueGet.GetValue() => SupportFlags;
}
