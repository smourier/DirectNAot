#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3dcommon/ne-d3dcommon-d3d_shader_variable_flags
public enum D3D_SHADER_VARIABLE_FLAGS
{
    D3D_SVF_USERPACKED = 1,
    D3D_SVF_USED = 2,
    D3D_SVF_INTERFACE_POINTER = 4,
    D3D_SVF_INTERFACE_PARAMETER = 8,
    D3D10_SVF_USERPACKED = 1,
    D3D10_SVF_USED = 2,
    D3D11_SVF_INTERFACE_POINTER = 4,
    D3D11_SVF_INTERFACE_PARAMETER = 8,
}
