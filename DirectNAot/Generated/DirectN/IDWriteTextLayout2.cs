namespace DirectN;

// https://learn.microsoft.com/windows/win32/DirectWrite/idwritetextlayout2
[SupportedOSPlatform("windows8.1")]
[GeneratedComInterface, Guid("1093c18f-8d5e-43f0-b064-0917311b525e")]
public partial interface IDWriteTextLayout2 : IDWriteTextLayout1
{
    // https://learn.microsoft.com/windows/win32/DirectWrite/idwritetextlayout2-getmetrics
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetMetrics(out DWRITE_TEXT_METRICS1 textMetrics);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_2/nf-dwrite_2-idwritetextlayout2-setverticalglyphorientation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetVerticalGlyphOrientation(DWRITE_VERTICAL_GLYPH_ORIENTATION glyphOrientation);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_2/nf-dwrite_2-idwritetextlayout2-getverticalglyphorientation
    [PreserveSig]
    public DWRITE_VERTICAL_GLYPH_ORIENTATION GetVerticalGlyphOrientation();
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_2/nf-dwrite_2-idwritetextlayout2-setlastlinewrapping
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetLastLineWrapping([MarshalAs(UnmanagedType.U4)] bool isLastLineWrappingEnabled);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_2/nf-dwrite_2-idwritetextlayout2-getlastlinewrapping
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    public bool GetLastLineWrapping();
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_2/nf-dwrite_2-idwritetextlayout2-setopticalalignment
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetOpticalAlignment(DWRITE_OPTICAL_ALIGNMENT opticalAlignment);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_2/nf-dwrite_2-idwritetextlayout2-getopticalalignment
    [PreserveSig]
    public DWRITE_OPTICAL_ALIGNMENT GetOpticalAlignment();
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_2/nf-dwrite_2-idwritetextlayout2-setfontfallback
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetFontFallback(IDWriteFontFallback fontFallback);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_2/nf-dwrite_2-idwritetextlayout2-getfontfallback
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetFontFallback(out IDWriteFontFallback fontFallback);
}
