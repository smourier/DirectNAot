#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_feature_data_shader_cache
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_FEATURE_DATA_SHADER_CACHE
{
    public D3D12_SHADER_CACHE_SUPPORT_FLAGS SupportFlags;
}
