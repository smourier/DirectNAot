#nullable enable
namespace DirectN;

public partial struct D3D12_PIXEL_SHADER_PARTIAL_PROGRAM_FIELDS_DESC
{
    public D3D12_LINE_RASTERIZATION_MODE LineRasterizationMode;
    public uint ForcedSampleCount;
    public BOOL AlphaToCoverageEnable;
    public BOOL DualSourceBlendEnable;
    public BOOL LateLinkRasterizerSubobject;
    public BOOL LateLinkBlendSubobject;
    public BOOL LateLinkSampleMaskSubobject;
    public BOOL LateLinkSampleDescSubobject;
    public BOOL LateLinkDepthStencilFormatSubobject;
    public BOOL LateLinkRenderTargetFormatSubobject;
    public BOOL LateLinkDepthStencilSubobject;
}
