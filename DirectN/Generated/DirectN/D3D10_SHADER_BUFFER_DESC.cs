#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10shader/ns-d3d10shader-d3d10_shader_buffer_desc
public partial struct D3D10_SHADER_BUFFER_DESC
{
    public PSTR Name;
    public D3D_CBUFFER_TYPE Type;
    public uint Variables;
    public uint Size;
    public uint uFlags;
}
