namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10_1shader/ns-d3d10_1shader-d3d10_shader_debug_scopevar_info
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D10_SHADER_DEBUG_SCOPEVAR_INFO
{
    public uint TokenId;
    public D3D10_SHADER_DEBUG_VARTYPE VarType;
    public D3D_SHADER_VARIABLE_CLASS Class;
    public uint Rows;
    public uint Columns;
    public uint StructMemberScope;
    public uint uArrayIndices;
    public uint ArrayElements;
    public uint ArrayStrides;
    public uint uVariables;
    public uint uFirstVariable;
}
