namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/nn-d2d1effectauthor-id2d1bordertransform
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("4998735c-3a19-473c-9781-656847e3a347")]
public partial interface ID2D1BorderTransform : ID2D1ConcreteTransform
{
    // https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/nf-d2d1effectauthor-id2d1bordertransform-setextendmodex
    [PreserveSig]
    void SetExtendModeX(D2D1_EXTEND_MODE extendMode);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/nf-d2d1effectauthor-id2d1bordertransform-setextendmodey
    [PreserveSig]
    void SetExtendModeY(D2D1_EXTEND_MODE extendMode);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/nf-d2d1effectauthor-id2d1bordertransform-getextendmodex
    [PreserveSig]
    D2D1_EXTEND_MODE GetExtendModeX();
    
    // https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/nf-d2d1effectauthor-id2d1bordertransform-getextendmodey
    [PreserveSig]
    D2D1_EXTEND_MODE GetExtendModeY();
}
