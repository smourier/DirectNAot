namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10_1shader/ns-d3d10_1shader-d3d10_shader_debug_input_info
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D10_SHADER_DEBUG_INPUT_INFO
{
    public uint Var;
    public D3D10_SHADER_DEBUG_REGTYPE InitialRegisterSet;
    public uint InitialBank;
    public uint InitialRegister;
    public uint InitialComponent;
    public uint InitialValue;
}
