#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ns-d3d11-d3d11_render_target_blend_desc
public partial struct D3D11_RENDER_TARGET_BLEND_DESC
{
    public BOOL BlendEnable;
    public D3D11_BLEND SrcBlend;
    public D3D11_BLEND DestBlend;
    public D3D11_BLEND_OP BlendOp;
    public D3D11_BLEND SrcBlendAlpha;
    public D3D11_BLEND DestBlendAlpha;
    public D3D11_BLEND_OP BlendOpAlpha;
    public byte RenderTargetWriteMask;
}
