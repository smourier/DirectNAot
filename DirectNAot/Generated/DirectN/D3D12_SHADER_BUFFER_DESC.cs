namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12shader/ns-d3d12shader-d3d12_shader_buffer_desc
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_SHADER_BUFFER_DESC
{
    public PSTR Name;
    public D3D_CBUFFER_TYPE Type;
    public uint Variables;
    public uint Size;
    public uint uFlags;
}
