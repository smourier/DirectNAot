namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1/nn-d2d1-id2d1bitmapbrush
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("2cd906aa-12e2-11dc-9fed-001143a055f9")]
public partial interface ID2D1BitmapBrush : ID2D1Brush
{
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1bitmapbrush-setextendmodex
    [PreserveSig]
    public void SetExtendModeX(D2D1_EXTEND_MODE extendModeX);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1bitmapbrush-setextendmodey
    [PreserveSig]
    public void SetExtendModeY(D2D1_EXTEND_MODE extendModeY);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1bitmapbrush-setinterpolationmode
    [PreserveSig]
    public void SetInterpolationMode(D2D1_BITMAP_INTERPOLATION_MODE interpolationMode);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1bitmapbrush-setbitmap
    [PreserveSig]
    public void SetBitmap(ID2D1Bitmap bitmap);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1bitmapbrush-getextendmodex
    [PreserveSig]
    public D2D1_EXTEND_MODE GetExtendModeX();
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1bitmapbrush-getextendmodey
    [PreserveSig]
    public D2D1_EXTEND_MODE GetExtendModeY();
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1bitmapbrush-getinterpolationmode
    [PreserveSig]
    public D2D1_BITMAP_INTERPOLATION_MODE GetInterpolationMode();
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1bitmapbrush-getbitmap
    [PreserveSig]
    public void GetBitmap(out ID2D1Bitmap bitmap);
}
