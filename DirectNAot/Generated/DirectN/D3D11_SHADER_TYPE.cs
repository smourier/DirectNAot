﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11shadertracing/ne-d3d11shadertracing-d3d11_shader_type
public enum D3D11_SHADER_TYPE
{
    D3D11_VERTEX_SHADER = 1,
    D3D11_HULL_SHADER = 2,
    D3D11_DOMAIN_SHADER = 3,
    D3D11_GEOMETRY_SHADER = 4,
    D3D11_PIXEL_SHADER = 5,
    D3D11_COMPUTE_SHADER = 6,
}
