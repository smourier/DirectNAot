#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ns-d3d11-d3d11_rasterizer_desc
public partial struct D3D11_RASTERIZER_DESC
{
    public D3D11_FILL_MODE FillMode;
    public D3D11_CULL_MODE CullMode;
    public BOOL FrontCounterClockwise;
    public int DepthBias;
    public float DepthBiasClamp;
    public float SlopeScaledDepthBias;
    public BOOL DepthClipEnable;
    public BOOL ScissorEnable;
    public BOOL MultisampleEnable;
    public BOOL AntialiasedLineEnable;
}
