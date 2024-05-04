#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ns-d3d11-d3d11_depth_stencil_desc
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D11_DEPTH_STENCIL_DESC
{
    [MarshalAs(UnmanagedType.U4)]
    public bool DepthEnable;
    public D3D11_DEPTH_WRITE_MASK DepthWriteMask;
    public D3D11_COMPARISON_FUNC DepthFunc;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool StencilEnable;
    public byte StencilReadMask;
    public byte StencilWriteMask;
    public D3D11_DEPTH_STENCILOP_DESC FrontFace;
    public D3D11_DEPTH_STENCILOP_DESC BackFace;
}
