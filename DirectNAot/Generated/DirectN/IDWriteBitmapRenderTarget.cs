namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite/nn-dwrite-idwritebitmaprendertarget
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("5e5a32a3-8dff-4773-9ff6-0696eab77267")]
public partial interface IDWriteBitmapRenderTarget
{
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritebitmaprendertarget-drawglyphrun
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT DrawGlyphRun(float baselineOriginX, float baselineOriginY, DWRITE_MEASURING_MODE measuringMode, in DWRITE_GLYPH_RUN glyphRun, IDWriteRenderingParams renderingParams, COLORREF textColor, nint/* nint */ blackBoxRect);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritebitmaprendertarget-getmemorydc
    [PreserveSig]
    public HDC GetMemoryDC();
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritebitmaprendertarget-getpixelsperdip
    [PreserveSig]
    public float GetPixelsPerDip();
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritebitmaprendertarget-setpixelsperdip
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetPixelsPerDip(float pixelsPerDip);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritebitmaprendertarget-getcurrenttransform
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetCurrentTransform(out DWRITE_MATRIX transform);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritebitmaprendertarget-setcurrenttransform
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetCurrentTransform(nint/* nint */ transform);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritebitmaprendertarget-getsize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetSize(out FoundationSIZE size);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritebitmaprendertarget-resize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Resize(uint width, uint height);
}
