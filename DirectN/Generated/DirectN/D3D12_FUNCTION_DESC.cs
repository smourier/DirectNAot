#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12shader/ns-d3d12shader-d3d12_function_desc
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_FUNCTION_DESC
{
    public uint Version;
    public PSTR Creator;
    public uint Flags;
    public uint ConstantBuffers;
    public uint BoundResources;
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
    public uint MovInstructionCount;
    public uint MovcInstructionCount;
    public uint ConversionInstructionCount;
    public uint BitwiseInstructionCount;
    public D3D_FEATURE_LEVEL MinFeatureLevel;
    public ulong RequiredFeatureFlags;
    public PSTR Name;
    public int FunctionParameterCount;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool HasReturn;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool Has10Level9VertexShader;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool Has10Level9PixelShader;
}
