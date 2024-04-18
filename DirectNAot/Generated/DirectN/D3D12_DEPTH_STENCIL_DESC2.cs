namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_DEPTH_STENCIL_DESC2
{
    [MarshalAs(UnmanagedType.U4)]
    public bool DepthEnable;
    public D3D12_DEPTH_WRITE_MASK DepthWriteMask;
    public D3D12_COMPARISON_FUNC DepthFunc;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool StencilEnable;
    public D3D12_DEPTH_STENCILOP_DESC1 FrontFace;
    public D3D12_DEPTH_STENCILOP_DESC1 BackFace;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool DepthBoundsTestEnable;
}
