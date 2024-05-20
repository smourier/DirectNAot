#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ns-d3d11-d3d11_rasterizer_desc
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D11_RASTERIZER_DESC
{
    public D3D11_FILL_MODE FillMode;
    public D3D11_CULL_MODE CullMode;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool FrontCounterClockwise;
    public int DepthBias;
    public float DepthBiasClamp;
    public float SlopeScaledDepthBias;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool DepthClipEnable;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool ScissorEnable;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool MultisampleEnable;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool AntialiasedLineEnable;
}
