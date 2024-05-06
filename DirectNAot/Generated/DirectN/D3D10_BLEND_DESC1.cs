#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10_1/ns-d3d10_1-d3d10_blend_desc1
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D10_BLEND_DESC1
{
    [MarshalAs(UnmanagedType.U4)]
    public bool AlphaToCoverageEnable;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool IndependentBlendEnable;
    public InlineArrayD3D10_RENDER_TARGET_BLEND_DESC1_8 RenderTarget;
}
