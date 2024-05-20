#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/ns-d2d1effectauthor-d2d1_blend_description
[StructLayout(LayoutKind.Sequential)]
public partial struct D2D1_BLEND_DESCRIPTION
{
    public D2D1_BLEND sourceBlend;
    public D2D1_BLEND destinationBlend;
    public D2D1_BLEND_OPERATION blendOperation;
    public D2D1_BLEND sourceBlendAlpha;
    public D2D1_BLEND destinationBlendAlpha;
    public D2D1_BLEND_OPERATION blendOperationAlpha;
    public InlineArraySingle_4 blendFactor;
}
