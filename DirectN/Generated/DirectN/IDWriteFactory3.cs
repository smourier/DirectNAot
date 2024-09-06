#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite_3/nn-dwrite_3-idwritefactory3
[SupportedOSPlatform("windows10.0.10240")]
[GeneratedComInterface, Guid("9a1b41c3-d3bb-466a-87fc-fe67556a3b65")]
public partial interface IDWriteFactory3 : IDWriteFactory2
{
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefactory3-createglyphrunanalysis
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateGlyphRunAnalysis(in DWRITE_GLYPH_RUN glyphRun, nint /* optional DWRITE_MATRIX* */ transform, DWRITE_RENDERING_MODE1 renderingMode, DWRITE_MEASURING_MODE measuringMode, DWRITE_GRID_FIT_MODE gridFitMode, DWRITE_TEXT_ANTIALIAS_MODE antialiasMode, float baselineOriginX, float baselineOriginY, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteGlyphRunAnalysis>))] out IDWriteGlyphRunAnalysis glyphRunAnalysis);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefactory3-createcustomrenderingparams
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateCustomRenderingParams(float gamma, float enhancedContrast, float grayscaleEnhancedContrast, float clearTypeLevel, DWRITE_PIXEL_GEOMETRY pixelGeometry, DWRITE_RENDERING_MODE1 renderingMode, DWRITE_GRID_FIT_MODE gridFitMode, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteRenderingParams3>))] out IDWriteRenderingParams3 renderingParams);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefactory3-createfontfacereference(wcharconst_filetimeconst_uint32_dwrite_font_simulations_idwritefontfacereference)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateFontFaceReference(IDWriteFontFile fontFile, uint faceIndex, DWRITE_FONT_SIMULATIONS fontSimulations, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteFontFaceReference>))] out IDWriteFontFaceReference fontFaceReference);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefactory3-createfontfacereference(wcharconst_filetimeconst_uint32_dwrite_font_simulations_idwritefontfacereference)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateFontFaceReference(PWSTR filePath, nint /* optional FILETIME* */ lastWriteTime, uint faceIndex, DWRITE_FONT_SIMULATIONS fontSimulations, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteFontFaceReference>))] out IDWriteFontFaceReference fontFaceReference);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefactory3-getsystemfontset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSystemFontSet([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteFontSet>))] out IDWriteFontSet fontSet);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefactory3-createfontsetbuilder
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateFontSetBuilder([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteFontSetBuilder>))] out IDWriteFontSetBuilder fontSetBuilder);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefactory3-createfontcollectionfromfontset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateFontCollectionFromFontSet(IDWriteFontSet fontSet, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteFontCollection1>))] out IDWriteFontCollection1 fontCollection);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefactory3-getsystemfontcollection
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSystemFontCollection(BOOL includeDownloadableFonts, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteFontCollection1>))] out IDWriteFontCollection1 fontCollection, BOOL checkForUpdates);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefactory3-getfontdownloadqueue
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFontDownloadQueue([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteFontDownloadQueue>))] out IDWriteFontDownloadQueue fontDownloadQueue);
}
