namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10effect/ns-d3d10effect-d3d10_effect_shader_desc
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D10_EFFECT_SHADER_DESC
{
    public nint pInputSignature;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool IsInline;
    public nint pBytecode;
    public uint BytecodeLength;
    public PSTR SODecl;
    public uint NumInputSignatureEntries;
    public uint NumOutputSignatureEntries;
}
