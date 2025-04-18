#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10/ns-d3d10-d3d10_rasterizer_desc
public partial struct D3D10_RASTERIZER_DESC
{
    public D3D10_FILL_MODE FillMode;
    public D3D10_CULL_MODE CullMode;
    public BOOL FrontCounterClockwise;
    public int DepthBias;
    public float DepthBiasClamp;
    public float SlopeScaledDepthBias;
    public BOOL DepthClipEnable;
    public BOOL ScissorEnable;
    public BOOL MultisampleEnable;
    public BOOL AntialiasedLineEnable;
}
