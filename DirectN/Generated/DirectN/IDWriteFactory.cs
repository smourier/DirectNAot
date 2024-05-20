﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite/nn-dwrite-idwritefactory
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("b859ee5a-d838-4b5b-a2e8-1adc7d93db48")]
public partial interface IDWriteFactory
{
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritefactory-getsystemfontcollection
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSystemFontCollection(out IDWriteFontCollection fontCollection, [MarshalAs(UnmanagedType.U4)] bool checkForUpdates);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritefactory-createcustomfontcollection
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateCustomFontCollection(IDWriteFontCollectionLoader collectionLoader, nint collectionKey, uint collectionKeySize, out IDWriteFontCollection fontCollection);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritefactory-registerfontcollectionloader
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RegisterFontCollectionLoader(IDWriteFontCollectionLoader fontCollectionLoader);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritefactory-unregisterfontcollectionloader
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UnregisterFontCollectionLoader(IDWriteFontCollectionLoader fontCollectionLoader);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritefactory-createfontfilereference
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateFontFileReference(PWSTR filePath, nint /* optional FILETIME* */ lastWriteTime, out IDWriteFontFile fontFile);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritefactory-createcustomfontfilereference
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateCustomFontFileReference(nint fontFileReferenceKey, uint fontFileReferenceKeySize, IDWriteFontFileLoader fontFileLoader, out IDWriteFontFile fontFile);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritefactory-createfontface
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateFontFace(DWRITE_FONT_FACE_TYPE fontFaceType, uint numberOfFiles, [In][MarshalUsing(CountElementName = nameof(numberOfFiles))] IDWriteFontFile[] fontFiles, uint faceIndex, DWRITE_FONT_SIMULATIONS fontFaceSimulationFlags, out IDWriteFontFace fontFace);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritefactory-createrenderingparams
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateRenderingParams(out IDWriteRenderingParams renderingParams);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritefactory-createmonitorrenderingparams
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateMonitorRenderingParams(HMONITOR monitor, out IDWriteRenderingParams renderingParams);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritefactory-createcustomrenderingparams
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateCustomRenderingParams(float gamma, float enhancedContrast, float clearTypeLevel, DWRITE_PIXEL_GEOMETRY pixelGeometry, DWRITE_RENDERING_MODE renderingMode, out IDWriteRenderingParams renderingParams);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritefactory-registerfontfileloader
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RegisterFontFileLoader(IDWriteFontFileLoader fontFileLoader);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritefactory-unregisterfontfileloader
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UnregisterFontFileLoader(IDWriteFontFileLoader fontFileLoader);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritefactory-createtextformat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateTextFormat(PWSTR fontFamilyName, IDWriteFontCollection? fontCollection, DWRITE_FONT_WEIGHT fontWeight, DWRITE_FONT_STYLE fontStyle, DWRITE_FONT_STRETCH fontStretch, float fontSize, PWSTR localeName, out IDWriteTextFormat textFormat);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritefactory-createtypography
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateTypography(out IDWriteTypography typography);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritefactory-getgdiinterop
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetGdiInterop(out IDWriteGdiInterop gdiInterop);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritefactory-createtextlayout
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateTextLayout([MarshalUsing(CountElementName = nameof(stringLength))] PWSTR @string, uint stringLength, IDWriteTextFormat textFormat, float maxWidth, float maxHeight, out IDWriteTextLayout textLayout);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritefactory-creategdicompatibletextlayout
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateGdiCompatibleTextLayout([MarshalUsing(CountElementName = nameof(stringLength))] PWSTR @string, uint stringLength, IDWriteTextFormat textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, nint /* optional DWRITE_MATRIX* */ transform, [MarshalAs(UnmanagedType.U4)] bool useGdiNatural, out IDWriteTextLayout textLayout);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritefactory-createellipsistrimmingsign
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateEllipsisTrimmingSign(IDWriteTextFormat textFormat, out IDWriteInlineObject trimmingSign);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritefactory-createtextanalyzer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateTextAnalyzer(out IDWriteTextAnalyzer textAnalyzer);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritefactory-createnumbersubstitution
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateNumberSubstitution(DWRITE_NUMBER_SUBSTITUTION_METHOD substitutionMethod, PWSTR localeName, [MarshalAs(UnmanagedType.U4)] bool ignoreUserOverride, out IDWriteNumberSubstitution numberSubstitution);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritefactory-createglyphrunanalysis
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateGlyphRunAnalysis(in DWRITE_GLYPH_RUN glyphRun, float pixelsPerDip, nint /* optional DWRITE_MATRIX* */ transform, DWRITE_RENDERING_MODE renderingMode, DWRITE_MEASURING_MODE measuringMode, float baselineOriginX, float baselineOriginY, out IDWriteGlyphRunAnalysis glyphRunAnalysis);
}