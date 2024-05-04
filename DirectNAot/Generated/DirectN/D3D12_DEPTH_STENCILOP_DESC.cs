#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_depth_stencilop_desc
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_DEPTH_STENCILOP_DESC
{
    public D3D12_STENCIL_OP StencilFailOp;
    public D3D12_STENCIL_OP StencilDepthFailOp;
    public D3D12_STENCIL_OP StencilPassOp;
    public D3D12_COMPARISON_FUNC StencilFunc;
}
