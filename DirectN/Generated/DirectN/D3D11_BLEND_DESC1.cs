#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11_1/ns-d3d11_1-d3d11_blend_desc1
public partial struct D3D11_BLEND_DESC1
{
    public BOOL AlphaToCoverageEnable;
    public BOOL IndependentBlendEnable;
    public InlineArrayD3D11_RENDER_TARGET_BLEND_DESC1_8 RenderTarget;
}
