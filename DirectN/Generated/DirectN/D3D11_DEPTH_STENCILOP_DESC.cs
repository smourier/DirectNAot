#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ns-d3d11-d3d11_depth_stencilop_desc
public partial struct D3D11_DEPTH_STENCILOP_DESC
{
    public D3D11_STENCIL_OP StencilFailOp;
    public D3D11_STENCIL_OP StencilDepthFailOp;
    public D3D11_STENCIL_OP StencilPassOp;
    public D3D11_COMPARISON_FUNC StencilFunc;
}
