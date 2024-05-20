#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12shader/ns-d3d12shader-d3d12_shader_desc
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_SHADER_DESC
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
    public D3D_PRIMITIVE InputPrimitive;
    public uint PatchConstantParameters;
    public uint cGSInstanceCount;
    public uint cControlPoints;
    public D3D_TESSELLATOR_OUTPUT_PRIMITIVE HSOutputPrimitive;
    public D3D_TESSELLATOR_PARTITIONING HSPartitioning;
    public D3D_TESSELLATOR_DOMAIN TessellatorDomain;
    public uint cBarrierInstructions;
    public uint cInterlockedInstructions;
    public uint cTextureStoreInstructions;
}
