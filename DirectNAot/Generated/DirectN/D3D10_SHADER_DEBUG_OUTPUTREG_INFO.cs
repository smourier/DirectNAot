#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10_1shader/ns-d3d10_1shader-d3d10_shader_debug_outputreg_info
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D10_SHADER_DEBUG_OUTPUTREG_INFO
{
    public D3D10_SHADER_DEBUG_REGTYPE OutputRegisterSet;
    public uint OutputReg;
    public uint TempArrayReg;
    public InlineArrayUInt324 OutputComponents;
    public InlineArrayD3D10_SHADER_DEBUG_OUTPUTVAR4 OutputVars;
    public uint IndexReg;
    public uint IndexComp;
}
