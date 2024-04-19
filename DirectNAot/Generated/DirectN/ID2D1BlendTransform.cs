namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/nn-d2d1effectauthor-id2d1blendtransform
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("63ac0b32-ba44-450f-8806-7f4ca1ff2f1b")]
public partial interface ID2D1BlendTransform : ID2D1ConcreteTransform
{
    // https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/nf-d2d1effectauthor-id2d1blendtransform-setdescription
    [PreserveSig]
    void SetDescription(in D2D1_BLEND_DESCRIPTION description);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/nf-d2d1effectauthor-id2d1blendtransform-getdescription
    [PreserveSig]
    void GetDescription(out D2D1_BLEND_DESCRIPTION description);
}
