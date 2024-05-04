#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11_1/ns-d3d11_1-d3d11_blend_desc1
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D11_BLEND_DESC1
{
    [MarshalAs(UnmanagedType.U4)]
    public bool AlphaToCoverageEnable;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool IndependentBlendEnable;
    public InlineArrayD3D11_RENDER_TARGET_BLEND_DESC18 RenderTarget;
}
