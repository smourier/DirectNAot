#nullable enable
namespace DirectN;

public partial struct D3D12_DEPTH_STENCIL_DESC2
{
    public BOOL DepthEnable;
    public D3D12_DEPTH_WRITE_MASK DepthWriteMask;
    public D3D12_COMPARISON_FUNC DepthFunc;
    public BOOL StencilEnable;
    public D3D12_DEPTH_STENCILOP_DESC1 FrontFace;
    public D3D12_DEPTH_STENCILOP_DESC1 BackFace;
    public BOOL DepthBoundsTestEnable;
}
