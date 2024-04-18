namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10_1/ns-d3d10_1-d3d10_render_target_blend_desc1
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D10_RENDER_TARGET_BLEND_DESC1
{
    [MarshalAs(UnmanagedType.U4)]
    public bool BlendEnable;
    public D3D10_BLEND SrcBlend;
    public D3D10_BLEND DestBlend;
    public D3D10_BLEND_OP BlendOp;
    public D3D10_BLEND SrcBlendAlpha;
    public D3D10_BLEND DestBlendAlpha;
    public D3D10_BLEND_OP BlendOpAlpha;
    public byte RenderTargetWriteMask;
}
