namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10/ns-d3d10-d3d10_depth_stencilop_desc
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D10_DEPTH_STENCILOP_DESC
{
    public D3D10_STENCIL_OP StencilFailOp;
    public D3D10_STENCIL_OP StencilDepthFailOp;
    public D3D10_STENCIL_OP StencilPassOp;
    public D3D10_COMPARISON_FUNC StencilFunc;
}
