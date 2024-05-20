#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11shadertracing/ns-d3d11shadertracing-d3d11_domain_shader_trace_desc
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D11_DOMAIN_SHADER_TRACE_DESC
{
    public ulong Invocation;
}
