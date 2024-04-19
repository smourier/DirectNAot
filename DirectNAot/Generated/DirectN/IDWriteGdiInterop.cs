namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite/nn-dwrite-idwritegdiinterop
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("1edd9491-9853-4299-898f-6432983b6f3a")]
public partial interface IDWriteGdiInterop
{
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritegdiinterop-createfontfromlogfont
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateFontFromLOGFONT(in LOGFONTW logFont, out IDWriteFont font);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritegdiinterop-convertfonttologfont
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ConvertFontToLOGFONT(IDWriteFont font, out LOGFONTW logFont, [MarshalAs(UnmanagedType.U4)] out bool isSystemFont);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritegdiinterop-convertfontfacetologfont
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ConvertFontFaceToLOGFONT(IDWriteFontFace font, out LOGFONTW logFont);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritegdiinterop-createfontfacefromhdc
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateFontFaceFromHdc(HDC hdc, out IDWriteFontFace fontFace);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritegdiinterop-createbitmaprendertarget
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateBitmapRenderTarget(HDC hdc, uint width, uint height, out IDWriteBitmapRenderTarget renderTarget);
}
