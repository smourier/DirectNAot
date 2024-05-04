#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10shader/ns-d3d10shader-d3d10_shader_desc
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D10_SHADER_DESC
{
    public uint Version;
    public PSTR Creator;
    public uint Flags;
    public uint ConstantBuffers;
    public uint BoundResources;
    public uint InputParameters;
    public uint OutputParameters;
    public uint InstructionCount;
    public uint TempRegisterCount;
    public uint TempArrayCount;
    public uint DefCount;
    public uint DclCount;
    public uint TextureNormalInstructions;
    public uint TextureLoadInstructions;
    public uint TextureCompInstructions;
    public uint TextureBiasInstructions;
    public uint TextureGradientInstructions;
    public uint FloatInstructionCount;
    public uint IntInstructionCount;
    public uint UintInstructionCount;
    public uint StaticFlowControlCount;
    public uint DynamicFlowControlCount;
    public uint MacroInstructionCount;
    public uint ArrayInstructionCount;
    public uint CutInstructionCount;
    public uint EmitInstructionCount;
    public D3D_PRIMITIVE_TOPOLOGY GSOutputTopology;
    public uint GSMaxOutputVertexCount;
}
