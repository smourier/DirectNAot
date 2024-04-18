namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10/ne-d3d10-d3d10_bind_flag
public enum D3D10_BIND_FLAG
{
    D3D10_BIND_VERTEX_BUFFER = 1,
    D3D10_BIND_INDEX_BUFFER = 2,
    D3D10_BIND_CONSTANT_BUFFER = 4,
    D3D10_BIND_SHADER_RESOURCE = 8,
    D3D10_BIND_STREAM_OUTPUT = 16,
    D3D10_BIND_RENDER_TARGET = 32,
    D3D10_BIND_DEPTH_STENCIL = 64,
}
