#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11shadertracing/ns-d3d11shadertracing-d3d11_trace_stats
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D11_TRACE_STATS
{
    public D3D11_SHADER_TRACE_DESC TraceDesc;
    public byte NumInvocationsInStamp;
    public byte TargetStampIndex;
    public uint NumTraceSteps;
    public InlineArrayByte_32 InputMask;
    public InlineArrayByte_32 OutputMask;
    public ushort NumTemps;
    public ushort MaxIndexableTempIndex;
    public InlineArrayUInt16_4096 IndexableTempSize;
    public ushort ImmediateConstantBufferSize;
    public InlineArrayUInt32_8 PixelPosition;
    public InlineArrayUInt64_4 PixelCoverageMask;
    public InlineArrayUInt64_4 PixelDiscardedMask;
    public InlineArrayUInt64_4 PixelCoverageMaskAfterShader;
    public InlineArrayUInt64_4 PixelCoverageMaskAfterA2CSampleMask;
    public InlineArrayUInt64_4 PixelCoverageMaskAfterA2CSampleMaskDepth;
    public InlineArrayUInt64_4 PixelCoverageMaskAfterA2CSampleMaskDepthStencil;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool PSOutputsDepth;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool PSOutputsMask;
    public D3D11_TRACE_GS_INPUT_PRIMITIVE GSInputPrimitive;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool GSInputsPrimitiveID;
    public InlineArrayByte_32 HSOutputPatchConstantMask;
    public InlineArrayByte_32 DSInputPatchConstantMask;
}
