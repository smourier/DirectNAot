namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite/nn-dwrite-idwritetextanalyzer
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("b7e6163e-7f46-43b4-84b3-e4e6249c365d")]
public partial interface IDWriteTextAnalyzer
{
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritetextanalyzer-analyzescript
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AnalyzeScript(IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, IDWriteTextAnalysisSink analysisSink);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritetextanalyzer-analyzebidi
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AnalyzeBidi(IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, IDWriteTextAnalysisSink analysisSink);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritetextanalyzer-analyzenumbersubstitution
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AnalyzeNumberSubstitution(IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, IDWriteTextAnalysisSink analysisSink);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritetextanalyzer-analyzelinebreakpoints
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AnalyzeLineBreakpoints(IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, IDWriteTextAnalysisSink analysisSink);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritetextanalyzer-getglyphs
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetGlyphs(PWSTR textString, uint textLength, IDWriteFontFace fontFace, [MarshalAs(UnmanagedType.U4)] bool isSideways, [MarshalAs(UnmanagedType.U4)] bool isRightToLeft, in DWRITE_SCRIPT_ANALYSIS scriptAnalysis, PWSTR localeName, IDWriteNumberSubstitution numberSubstitution, nint /* optional DWRITE_TYPOGRAPHIC_FEATURES */ features, nint /* optional uint */ featureRangeLengths, uint featureRanges, uint maxGlyphCount, out ushort clusterMap, out DWRITE_SHAPING_TEXT_PROPERTIES textProps, out ushort glyphIndices, out DWRITE_SHAPING_GLYPH_PROPERTIES glyphProps, out uint actualGlyphCount);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritetextanalyzer-getglyphplacements
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetGlyphPlacements(PWSTR textString, in ushort clusterMap, ref DWRITE_SHAPING_TEXT_PROPERTIES textProps, uint textLength, in ushort glyphIndices, in DWRITE_SHAPING_GLYPH_PROPERTIES glyphProps, uint glyphCount, IDWriteFontFace fontFace, float fontEmSize, [MarshalAs(UnmanagedType.U4)] bool isSideways, [MarshalAs(UnmanagedType.U4)] bool isRightToLeft, in DWRITE_SCRIPT_ANALYSIS scriptAnalysis, PWSTR localeName, nint /* optional DWRITE_TYPOGRAPHIC_FEATURES */ features, nint /* optional uint */ featureRangeLengths, uint featureRanges, out float glyphAdvances, out DWRITE_GLYPH_OFFSET glyphOffsets);
    
    // https://learn.microsoft.com/windows/win32/DirectWrite/idwritetextanalyzer-getgdicompatibleglyphplacements
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetGdiCompatibleGlyphPlacements(PWSTR textString, in ushort clusterMap, in DWRITE_SHAPING_TEXT_PROPERTIES textProps, uint textLength, in ushort glyphIndices, in DWRITE_SHAPING_GLYPH_PROPERTIES glyphProps, uint glyphCount, IDWriteFontFace fontFace, float fontEmSize, float pixelsPerDip, nint /* optional DWRITE_MATRIX */ transform, [MarshalAs(UnmanagedType.U4)] bool useGdiNatural, [MarshalAs(UnmanagedType.U4)] bool isSideways, [MarshalAs(UnmanagedType.U4)] bool isRightToLeft, in DWRITE_SCRIPT_ANALYSIS scriptAnalysis, PWSTR localeName, nint /* optional DWRITE_TYPOGRAPHIC_FEATURES */ features, nint /* optional uint */ featureRangeLengths, uint featureRanges, out float glyphAdvances, out DWRITE_GLYPH_OFFSET glyphOffsets);
}
