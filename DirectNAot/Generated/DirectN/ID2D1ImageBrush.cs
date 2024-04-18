namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1_1/nn-d2d1_1-id2d1imagebrush
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("fe9e984d-3f95-407c-b5db-cb94d4e8f87c")]
public partial interface ID2D1ImageBrush : ID2D1Brush
{
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1imagebrush-setimage
    [PreserveSig]
    public void SetImage(ID2D1Image image);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1imagebrush-setextendmodex
    [PreserveSig]
    public void SetExtendModeX(D2D1_EXTEND_MODE extendModeX);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1imagebrush-setextendmodey
    [PreserveSig]
    public void SetExtendModeY(D2D1_EXTEND_MODE extendModeY);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1imagebrush-setinterpolationmode
    [PreserveSig]
    public void SetInterpolationMode(D2D1_INTERPOLATION_MODE interpolationMode);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1imagebrush-setsourcerectangle
    [PreserveSig]
    public void SetSourceRectangle(in D2D_RECT_F sourceRectangle);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1imagebrush-getimage
    [PreserveSig]
    public void GetImage(out ID2D1Image image);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1imagebrush-getextendmodex
    [PreserveSig]
    public D2D1_EXTEND_MODE GetExtendModeX();
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1imagebrush-getextendmodey
    [PreserveSig]
    public D2D1_EXTEND_MODE GetExtendModeY();
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1imagebrush-getinterpolationmode
    [PreserveSig]
    public D2D1_INTERPOLATION_MODE GetInterpolationMode();
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1imagebrush-getsourcerectangle
    [PreserveSig]
    public void GetSourceRectangle(out D2D_RECT_F sourceRectangle);
}
