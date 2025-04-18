#nullable enable
namespace DirectN;

public partial struct D3D12_RASTERIZER_DESC1
{
    public D3D12_FILL_MODE FillMode;
    public D3D12_CULL_MODE CullMode;
    public BOOL FrontCounterClockwise;
    public float DepthBias;
    public float DepthBiasClamp;
    public float SlopeScaledDepthBias;
    public BOOL DepthClipEnable;
    public BOOL MultisampleEnable;
    public BOOL AntialiasedLineEnable;
    public uint ForcedSampleCount;
    public D3D12_CONSERVATIVE_RASTERIZATION_MODE ConservativeRaster;
}
