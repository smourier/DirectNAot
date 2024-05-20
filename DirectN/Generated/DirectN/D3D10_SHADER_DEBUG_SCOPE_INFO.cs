#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10_1shader/ns-d3d10_1shader-d3d10_shader_debug_scope_info
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D10_SHADER_DEBUG_SCOPE_INFO
{
    public D3D10_SHADER_DEBUG_SCOPETYPE ScopeType;
    public uint Name;
    public uint uNameLen;
    public uint uVariables;
    public uint VariableData;
}
