namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite_1/nn-dwrite_1-idwritetextanalyzer1
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("80dad800-e21f-4e83-96ce-bfcce500db7c")]
public partial interface IDWriteTextAnalyzer1 : IDWriteTextAnalyzer
{
    // https://learn.microsoft.com/windows/win32/api/dwrite_1/nf-dwrite_1-idwritetextanalyzer1-applycharacterspacing
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT ApplyCharacterSpacing(float leadingSpacing, float trailingSpacing, float minimumAdvanceWidth, uint textLength, uint glyphCount, in ushort clusterMap, in float glyphAdvances, in DWRITE_GLYPH_OFFSET glyphOffsets, in DWRITE_SHAPING_GLYPH_PROPERTIES glyphProperties, out float modifiedGlyphAdvances, out DWRITE_GLYPH_OFFSET modifiedGlyphOffsets);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_1/nf-dwrite_1-idwritetextanalyzer1-getbaseline
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetBaseline(IDWriteFontFace fontFace, DWRITE_BASELINE baseline, [MarshalAs(UnmanagedType.U4)] bool isVertical, [MarshalAs(UnmanagedType.U4)] bool isSimulationAllowed, DWRITE_SCRIPT_ANALYSIS scriptAnalysis, PWSTR localeName, out int baselineCoordinate, [MarshalAs(UnmanagedType.U4)] out bool exists);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_1/nf-dwrite_1-idwritetextanalyzer1-analyzeverticalglyphorientation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT AnalyzeVerticalGlyphOrientation(IDWriteTextAnalysisSource1 analysisSource, uint textPosition, uint textLength, IDWriteTextAnalysisSink1 analysisSink);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_1/nf-dwrite_1-idwritetextanalyzer1-getglyphorientationtransform
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetGlyphOrientationTransform(DWRITE_GLYPH_ORIENTATION_ANGLE glyphOrientationAngle, [MarshalAs(UnmanagedType.U4)] bool isSideways, out DWRITE_MATRIX transform);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_1/nf-dwrite_1-idwritetextanalyzer1-getscriptproperties
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetScriptProperties(DWRITE_SCRIPT_ANALYSIS scriptAnalysis, out DWRITE_SCRIPT_PROPERTIES scriptProperties);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_1/nf-dwrite_1-idwritetextanalyzer1-gettextcomplexity
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetTextComplexity(PWSTR textString, uint textLength, IDWriteFontFace fontFace, [MarshalAs(UnmanagedType.U4)] out bool isTextSimple, ref uint textLengthRead, nint/* nint */ glyphIndices);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_1/nf-dwrite_1-idwritetextanalyzer1-getjustificationopportunities
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetJustificationOpportunities(IDWriteFontFace fontFace, float fontEmSize, DWRITE_SCRIPT_ANALYSIS scriptAnalysis, uint textLength, uint glyphCount, PWSTR textString, in ushort clusterMap, in DWRITE_SHAPING_GLYPH_PROPERTIES glyphProperties, out DWRITE_JUSTIFICATION_OPPORTUNITY justificationOpportunities);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_1/nf-dwrite_1-idwritetextanalyzer1-justifyglyphadvances
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT JustifyGlyphAdvances(float lineWidth, uint glyphCount, in DWRITE_JUSTIFICATION_OPPORTUNITY justificationOpportunities, in float glyphAdvances, in DWRITE_GLYPH_OFFSET glyphOffsets, out float justifiedGlyphAdvances, nint/* nint */ justifiedGlyphOffsets);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_1/nf-dwrite_1-idwritetextanalyzer1-getjustifiedglyphs
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetJustifiedGlyphs(IDWriteFontFace fontFace, float fontEmSize, DWRITE_SCRIPT_ANALYSIS scriptAnalysis, uint textLength, uint glyphCount, uint maxGlyphCount, nint/* nint */ clusterMap, in ushort glyphIndices, in float glyphAdvances, in float justifiedGlyphAdvances, in DWRITE_GLYPH_OFFSET justifiedGlyphOffsets, in DWRITE_SHAPING_GLYPH_PROPERTIES glyphProperties, ref uint actualGlyphCount, nint/* nint */ modifiedClusterMap, out ushort modifiedGlyphIndices, out float modifiedGlyphAdvances, out DWRITE_GLYPH_OFFSET modifiedGlyphOffsets);
}
