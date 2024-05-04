#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ne-d3d12-d3d12_shader_cache_control_flags
[Flags]
public enum D3D12_SHADER_CACHE_CONTROL_FLAGS
{
    D3D12_SHADER_CACHE_CONTROL_FLAG_DISABLE = 1,
    D3D12_SHADER_CACHE_CONTROL_FLAG_ENABLE = 2,
    D3D12_SHADER_CACHE_CONTROL_FLAG_CLEAR = 4,
}
