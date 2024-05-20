#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ne-d3d12-d3d12_shader_min_precision_support
[Flags]
public enum D3D12_SHADER_MIN_PRECISION_SUPPORT
{
    D3D12_SHADER_MIN_PRECISION_SUPPORT_NONE = 0,
    D3D12_SHADER_MIN_PRECISION_SUPPORT_10_BIT = 1,
    D3D12_SHADER_MIN_PRECISION_SUPPORT_16_BIT = 2,
}
