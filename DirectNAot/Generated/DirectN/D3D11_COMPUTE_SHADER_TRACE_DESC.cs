namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11shadertracing/ns-d3d11shadertracing-d3d11_compute_shader_trace_desc
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D11_COMPUTE_SHADER_TRACE_DESC
{
    public ulong Invocation;
    public InlineArrayUInt323 ThreadIDInGroup;
    public InlineArrayUInt323 ThreadGroupID;
}
