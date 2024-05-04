#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10_1shader/ns-d3d10_1shader-d3d10_shader_debug_inst_info
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D10_SHADER_DEBUG_INST_INFO
{
    public uint Id;
    public uint Opcode;
    public uint uOutputs;
    public InlineArrayD3D10_SHADER_DEBUG_OUTPUTREG_INFO2 pOutputs;
    public uint TokenId;
    public uint NestingLevel;
    public uint Scopes;
    public uint ScopeInfo;
    public uint AccessedVars;
    public uint AccessedVarsInfo;
}
