#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1_1/nn-d2d1_1-id2d1imagebrush
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("fe9e984d-3f95-407c-b5db-cb94d4e8f87c")]
public partial interface ID2D1ImageBrush : ID2D1Brush
{
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1imagebrush-setimage
    [PreserveSig]
    void SetImage(ID2D1Image? image);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1imagebrush-setextendmodex
    [PreserveSig]
    void SetExtendModeX(D2D1_EXTEND_MODE extendModeX);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1imagebrush-setextendmodey
    [PreserveSig]
    void SetExtendModeY(D2D1_EXTEND_MODE extendModeY);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1imagebrush-setinterpolationmode
    [PreserveSig]
    void SetInterpolationMode(D2D1_INTERPOLATION_MODE interpolationMode);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1imagebrush-setsourcerectangle
    [PreserveSig]
    void SetSourceRectangle(in D2D_RECT_F sourceRectangle);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1imagebrush-getimage
    [PreserveSig]
    void GetImage([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1Image>))] out ID2D1Image image);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1imagebrush-getextendmodex
    [PreserveSig]
    D2D1_EXTEND_MODE GetExtendModeX();
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1imagebrush-getextendmodey
    [PreserveSig]
    D2D1_EXTEND_MODE GetExtendModeY();
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1imagebrush-getinterpolationmode
    [PreserveSig]
    D2D1_INTERPOLATION_MODE GetInterpolationMode();
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1imagebrush-getsourcerectangle
    [PreserveSig]
    void GetSourceRectangle(out D2D_RECT_F sourceRectangle);
}
