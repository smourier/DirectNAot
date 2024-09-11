#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite/nn-dwrite-idwritetextanalyzer
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("b7e6163e-7f46-43b4-84b3-e4e6249c365d")]
public partial interface IDWriteTextAnalyzer
{
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritetextanalyzer-analyzescript
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AnalyzeScript([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteTextAnalysisSource>))] IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteTextAnalysisSink>))] IDWriteTextAnalysisSink analysisSink);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritetextanalyzer-analyzebidi
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AnalyzeBidi([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteTextAnalysisSource>))] IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteTextAnalysisSink>))] IDWriteTextAnalysisSink analysisSink);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritetextanalyzer-analyzenumbersubstitution
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AnalyzeNumberSubstitution([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteTextAnalysisSource>))] IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteTextAnalysisSink>))] IDWriteTextAnalysisSink analysisSink);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritetextanalyzer-analyzelinebreakpoints
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AnalyzeLineBreakpoints([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteTextAnalysisSource>))] IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteTextAnalysisSink>))] IDWriteTextAnalysisSink analysisSink);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritetextanalyzer-getglyphs
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetGlyphs([MarshalUsing(CountElementName = nameof(textLength))] PWSTR textString, uint textLength, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteFontFace>))] IDWriteFontFace fontFace, BOOL isSideways, BOOL isRightToLeft, in DWRITE_SCRIPT_ANALYSIS scriptAnalysis, PWSTR localeName, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteNumberSubstitution?>))] IDWriteNumberSubstitution? numberSubstitution, nint /* optional DWRITE_TYPOGRAPHIC_FEATURES** */ features, nint /* optional uint* */ featureRangeLengths, uint featureRanges, uint maxGlyphCount, [In][Out][MarshalUsing(CountElementName = nameof(textLength))] ushort[] clusterMap, [In][Out][MarshalUsing(CountElementName = nameof(textLength))] DWRITE_SHAPING_TEXT_PROPERTIES[] textProps, [In][Out][MarshalUsing(CountElementName = nameof(maxGlyphCount))] ushort[] glyphIndices, [In][Out][MarshalUsing(CountElementName = nameof(maxGlyphCount))] DWRITE_SHAPING_GLYPH_PROPERTIES[] glyphProps, out uint actualGlyphCount);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritetextanalyzer-getglyphplacements
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetGlyphPlacements([MarshalUsing(CountElementName = nameof(textLength))] PWSTR textString, [In][MarshalUsing(CountElementName = nameof(textLength))] ushort[] clusterMap, [In][Out][MarshalUsing(CountElementName = nameof(textLength))] DWRITE_SHAPING_TEXT_PROPERTIES[] textProps, uint textLength, [In][MarshalUsing(CountElementName = nameof(glyphCount))] ushort[] glyphIndices, [In][MarshalUsing(CountElementName = nameof(glyphCount))] DWRITE_SHAPING_GLYPH_PROPERTIES[] glyphProps, uint glyphCount, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteFontFace>))] IDWriteFontFace fontFace, float fontEmSize, BOOL isSideways, BOOL isRightToLeft, in DWRITE_SCRIPT_ANALYSIS scriptAnalysis, PWSTR localeName, nint /* optional DWRITE_TYPOGRAPHIC_FEATURES** */ features, nint /* optional uint* */ featureRangeLengths, uint featureRanges, [In][Out][MarshalUsing(CountElementName = nameof(glyphCount))] float[] glyphAdvances, [In][Out][MarshalUsing(CountElementName = nameof(glyphCount))] DWRITE_GLYPH_OFFSET[] glyphOffsets);
    
    // https://learn.microsoft.com/windows/win32/DirectWrite/idwritetextanalyzer-getgdicompatibleglyphplacements
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetGdiCompatibleGlyphPlacements([MarshalUsing(CountElementName = nameof(textLength))] PWSTR textString, [In][MarshalUsing(CountElementName = nameof(textLength))] ushort[] clusterMap, [In][MarshalUsing(CountElementName = nameof(textLength))] DWRITE_SHAPING_TEXT_PROPERTIES[] textProps, uint textLength, [In][MarshalUsing(CountElementName = nameof(glyphCount))] ushort[] glyphIndices, [In][MarshalUsing(CountElementName = nameof(glyphCount))] DWRITE_SHAPING_GLYPH_PROPERTIES[] glyphProps, uint glyphCount, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteFontFace>))] IDWriteFontFace fontFace, float fontEmSize, float pixelsPerDip, nint /* optional DWRITE_MATRIX* */ transform, BOOL useGdiNatural, BOOL isSideways, BOOL isRightToLeft, in DWRITE_SCRIPT_ANALYSIS scriptAnalysis, PWSTR localeName, nint /* optional DWRITE_TYPOGRAPHIC_FEATURES** */ features, nint /* optional uint* */ featureRangeLengths, uint featureRanges, [In][Out][MarshalUsing(CountElementName = nameof(glyphCount))] float[] glyphAdvances, [In][Out][MarshalUsing(CountElementName = nameof(glyphCount))] DWRITE_GLYPH_OFFSET[] glyphOffsets);
}
