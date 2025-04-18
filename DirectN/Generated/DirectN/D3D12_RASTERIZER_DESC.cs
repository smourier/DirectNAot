#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_rasterizer_desc
public partial struct D3D12_RASTERIZER_DESC
{
    public D3D12_FILL_MODE FillMode;
    public D3D12_CULL_MODE CullMode;
    public BOOL FrontCounterClockwise;
    public int DepthBias;
    public float DepthBiasClamp;
    public float SlopeScaledDepthBias;
    public BOOL DepthClipEnable;
    public BOOL MultisampleEnable;
    public BOOL AntialiasedLineEnable;
    public uint ForcedSampleCount;
    public D3D12_CONSERVATIVE_RASTERIZATION_MODE ConservativeRaster;
}
