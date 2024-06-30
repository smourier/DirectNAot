#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12shader/ns-d3d12shader-d3d12_shader_type_desc
public partial struct D3D12_SHADER_TYPE_DESC
{
    public D3D_SHADER_VARIABLE_CLASS Class;
    public D3D_SHADER_VARIABLE_TYPE Type;
    public uint Rows;
    public uint Columns;
    public uint Elements;
    public uint Members;
    public uint Offset;
    public PSTR Name;
}
