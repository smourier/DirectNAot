#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ns-d3d11-d3d11_blend_desc
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D11_BLEND_DESC
{
    [MarshalAs(UnmanagedType.U4)]
    public bool AlphaToCoverageEnable;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool IndependentBlendEnable;
    public InlineArrayD3D11_RENDER_TARGET_BLEND_DESC8 RenderTarget;
}
