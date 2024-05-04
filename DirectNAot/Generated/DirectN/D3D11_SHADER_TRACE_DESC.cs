#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11shadertracing/ns-d3d11shadertracing-d3d11_shader_trace_desc
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D11_SHADER_TRACE_DESC
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public D3D11_VERTEX_SHADER_TRACE_DESC VertexShaderTraceDesc;
        
        [FieldOffset(0)]
        public D3D11_HULL_SHADER_TRACE_DESC HullShaderTraceDesc;
        
        [FieldOffset(0)]
        public D3D11_DOMAIN_SHADER_TRACE_DESC DomainShaderTraceDesc;
        
        [FieldOffset(0)]
        public D3D11_GEOMETRY_SHADER_TRACE_DESC GeometryShaderTraceDesc;
        
        [FieldOffset(0)]
        public D3D11_PIXEL_SHADER_TRACE_DESC PixelShaderTraceDesc;
        
        [FieldOffset(0)]
        public D3D11_COMPUTE_SHADER_TRACE_DESC ComputeShaderTraceDesc;
    }
    
    public D3D11_SHADER_TYPE Type;
    public uint Flags;
    public _Anonymous_e__Union Anonymous;
}
