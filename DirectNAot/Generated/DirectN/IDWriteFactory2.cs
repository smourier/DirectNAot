namespace DirectN;

// https://learn.microsoft.com/windows/win32/DirectWrite/idwritefactory2
[SupportedOSPlatform("windows8.1")]
[GeneratedComInterface, Guid("0439fc60-ca44-4994-8dee-3a9af7b732ec")]
public partial interface IDWriteFactory2 : IDWriteFactory1
{
    // https://learn.microsoft.com/windows/win32/DirectWrite/idwritefactory2-getsystemfontfallback
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSystemFontFallback(out IDWriteFontFallback fontFallback);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_2/nf-dwrite_2-idwritefactory2-createfontfallbackbuilder
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateFontFallbackBuilder(out IDWriteFontFallbackBuilder fontFallbackBuilder);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_2/nf-dwrite_2-idwritefactory2-translatecolorglyphrun
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TranslateColorGlyphRun(float baselineOriginX, float baselineOriginY, in DWRITE_GLYPH_RUN glyphRun, nint/* nint */ glyphRunDescription, DWRITE_MEASURING_MODE measuringMode, nint/* nint */ worldToDeviceTransform, uint colorPaletteIndex, out IDWriteColorGlyphRunEnumerator colorLayers);
    
    // https://learn.microsoft.com/windows/win32/DirectWrite/idwritefactory2-createcustomrenderingparams
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateCustomRenderingParams(float gamma, float enhancedContrast, float grayscaleEnhancedContrast, float clearTypeLevel, DWRITE_PIXEL_GEOMETRY pixelGeometry, DWRITE_RENDERING_MODE renderingMode, DWRITE_GRID_FIT_MODE gridFitMode, out IDWriteRenderingParams2 renderingParams);
    
    // https://learn.microsoft.com/windows/win32/DirectWrite/idwritefactory2-createglyphrunanalysis
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateGlyphRunAnalysis(in DWRITE_GLYPH_RUN glyphRun, nint/* nint */ transform, DWRITE_RENDERING_MODE renderingMode, DWRITE_MEASURING_MODE measuringMode, DWRITE_GRID_FIT_MODE gridFitMode, DWRITE_TEXT_ANTIALIAS_MODE antialiasMode, float baselineOriginX, float baselineOriginY, out IDWriteGlyphRunAnalysis glyphRunAnalysis);
}
