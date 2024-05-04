#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10shader/ns-d3d10shader-d3d10_shader_input_bind_desc
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D10_SHADER_INPUT_BIND_DESC
{
    public PSTR Name;
    public D3D_SHADER_INPUT_TYPE Type;
    public uint BindPoint;
    public uint BindCount;
    public uint uFlags;
    public D3D_RESOURCE_RETURN_TYPE ReturnType;
    public D3D_SRV_DIMENSION Dimension;
    public uint NumSamples;
}
