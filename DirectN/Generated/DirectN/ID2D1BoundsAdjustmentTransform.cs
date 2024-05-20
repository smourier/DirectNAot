#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/nn-d2d1effectauthor-id2d1boundsadjustmenttransform
[GeneratedComInterface, Guid("90f732e2-5092-4606-a819-8651970baccd")]
public partial interface ID2D1BoundsAdjustmentTransform : ID2D1TransformNode
{
    // https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/nf-d2d1effectauthor-id2d1boundsadjustmenttransform-setoutputbounds
    [PreserveSig]
    void SetOutputBounds(in RECT outputBounds);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/nf-d2d1effectauthor-id2d1boundsadjustmenttransform-getoutputbounds
    [PreserveSig]
    void GetOutputBounds(out RECT outputBounds);
}
