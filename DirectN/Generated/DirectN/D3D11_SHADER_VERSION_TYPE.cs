#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11shader/ne-d3d11shader-d3d11_shader_version_type
public enum D3D11_SHADER_VERSION_TYPE
{
    D3D11_SHVER_PIXEL_SHADER = 0,
    D3D11_SHVER_VERTEX_SHADER = 1,
    D3D11_SHVER_GEOMETRY_SHADER = 2,
    D3D11_SHVER_HULL_SHADER = 3,
    D3D11_SHVER_DOMAIN_SHADER = 4,
    D3D11_SHVER_COMPUTE_SHADER = 5,
    D3D11_SHVER_RESERVED0 = 65520,
}
