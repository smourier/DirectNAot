#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11shadertracing/ns-d3d11shadertracing-d3d11_pixel_shader_trace_desc
public partial struct D3D11_PIXEL_SHADER_TRACE_DESC
{
    public ulong Invocation;
    public int X;
    public int Y;
    public ulong SampleMask;
}
