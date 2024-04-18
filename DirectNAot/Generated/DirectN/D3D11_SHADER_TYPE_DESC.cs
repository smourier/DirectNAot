namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11shader/ns-d3d11shader-d3d11_shader_type_desc
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D11_SHADER_TYPE_DESC
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
