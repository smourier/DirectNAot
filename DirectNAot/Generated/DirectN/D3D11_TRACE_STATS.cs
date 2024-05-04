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
    public InlineArrayByte32 InputMask;
    public InlineArrayByte32 OutputMask;
    public ushort NumTemps;
    public ushort MaxIndexableTempIndex;
    public InlineArrayUInt164096 IndexableTempSize;
    public ushort ImmediateConstantBufferSize;
    public InlineArrayUInt328 PixelPosition;
    public InlineArrayUInt644 PixelCoverageMask;
    public InlineArrayUInt644 PixelDiscardedMask;
    public InlineArrayUInt644 PixelCoverageMaskAfterShader;
    public InlineArrayUInt644 PixelCoverageMaskAfterA2CSampleMask;
    public InlineArrayUInt644 PixelCoverageMaskAfterA2CSampleMaskDepth;
    public InlineArrayUInt644 PixelCoverageMaskAfterA2CSampleMaskDepthStencil;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool PSOutputsDepth;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool PSOutputsMask;
    public D3D11_TRACE_GS_INPUT_PRIMITIVE GSInputPrimitive;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool GSInputsPrimitiveID;
    public InlineArrayByte32 HSOutputPatchConstantMask;
    public InlineArrayByte32 DSInputPatchConstantMask;
}
