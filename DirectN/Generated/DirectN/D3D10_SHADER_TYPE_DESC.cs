#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10shader/ns-d3d10shader-d3d10_shader_type_desc
public partial struct D3D10_SHADER_TYPE_DESC
{
    public D3D_SHADER_VARIABLE_CLASS Class;
    public D3D_SHADER_VARIABLE_TYPE Type;
    public uint Rows;
    public uint Columns;
    public uint Elements;
    public uint Members;
    public uint Offset;
}
