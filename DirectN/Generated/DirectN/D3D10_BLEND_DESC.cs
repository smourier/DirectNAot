#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10/ns-d3d10-d3d10_blend_desc
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D10_BLEND_DESC
{
    [MarshalAs(UnmanagedType.U4)]
    public bool AlphaToCoverageEnable;
    public InlineArrayBOOL_8 BlendEnable;
    public D3D10_BLEND SrcBlend;
    public D3D10_BLEND DestBlend;
    public D3D10_BLEND_OP BlendOp;
    public D3D10_BLEND SrcBlendAlpha;
    public D3D10_BLEND DestBlendAlpha;
    public D3D10_BLEND_OP BlendOpAlpha;
    public InlineArrayByte_8 RenderTargetWriteMask;
}
