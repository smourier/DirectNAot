#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10effect/ns-d3d10effect-d3d10_pass_shader_desc
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D10_PASS_SHADER_DESC
{
    public nint pShaderVariable;
    public uint ShaderIndex;
}
