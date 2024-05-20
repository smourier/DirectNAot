#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3dcommon/ne-d3dcommon-d3d_shader_input_flags
public enum D3D_SHADER_INPUT_FLAGS
{
    D3D_SIF_USERPACKED = 1,
    D3D_SIF_COMPARISON_SAMPLER = 2,
    D3D_SIF_TEXTURE_COMPONENT_0 = 4,
    D3D_SIF_TEXTURE_COMPONENT_1 = 8,
    D3D_SIF_TEXTURE_COMPONENTS = 12,
    D3D_SIF_UNUSED = 16,
    D3D10_SIF_USERPACKED = 1,
    D3D10_SIF_COMPARISON_SAMPLER = 2,
    D3D10_SIF_TEXTURE_COMPONENT_0 = 4,
    D3D10_SIF_TEXTURE_COMPONENT_1 = 8,
    D3D10_SIF_TEXTURE_COMPONENTS = 12,
}
