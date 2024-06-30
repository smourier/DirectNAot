#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3dcompiler/ns-d3dcompiler-d3d_shader_data
public partial struct D3D_SHADER_DATA
{
    public nint pBytecode;
    public nuint BytecodeLength;
}
