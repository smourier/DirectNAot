#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite_1/nn-dwrite_1-idwritetextanalyzer1
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("80dad800-e21f-4e83-96ce-bfcce500db7c")]
public partial interface IDWriteTextAnalyzer1 : IDWriteTextAnalyzer
{
    // https://learn.microsoft.com/windows/win32/api/dwrite_1/nf-dwrite_1-idwritetextanalyzer1-applycharacterspacing
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ApplyCharacterSpacing(float leadingSpacing, float trailingSpacing, float minimumAdvanceWidth, uint textLength, uint glyphCount, [In][MarshalUsing(CountElementName = nameof(textLength))] ushort[] clusterMap, [In][MarshalUsing(CountElementName = nameof(glyphCount))] float[] glyphAdvances, [In][MarshalUsing(CountElementName = nameof(glyphCount))] DWRITE_GLYPH_OFFSET[] glyphOffsets, [In][MarshalUsing(CountElementName = nameof(glyphCount))] DWRITE_SHAPING_GLYPH_PROPERTIES[] glyphProperties, [In][Out][MarshalUsing(CountElementName = nameof(glyphCount))] float[] modifiedGlyphAdvances, [In][Out][MarshalUsing(CountElementName = nameof(glyphCount))] DWRITE_GLYPH_OFFSET[] modifiedGlyphOffsets);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_1/nf-dwrite_1-idwritetextanalyzer1-getbaseline
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBaseline([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteFontFace>))] IDWriteFontFace fontFace, DWRITE_BASELINE baseline, BOOL isVertical, BOOL isSimulationAllowed, DWRITE_SCRIPT_ANALYSIS scriptAnalysis, PWSTR localeName, out int baselineCoordinate, out BOOL exists);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_1/nf-dwrite_1-idwritetextanalyzer1-analyzeverticalglyphorientation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AnalyzeVerticalGlyphOrientation([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteTextAnalysisSource1>))] IDWriteTextAnalysisSource1 analysisSource, uint textPosition, uint textLength, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteTextAnalysisSink1>))] IDWriteTextAnalysisSink1 analysisSink);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_1/nf-dwrite_1-idwritetextanalyzer1-getglyphorientationtransform
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetGlyphOrientationTransform(DWRITE_GLYPH_ORIENTATION_ANGLE glyphOrientationAngle, BOOL isSideways, out DWRITE_MATRIX transform);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_1/nf-dwrite_1-idwritetextanalyzer1-getscriptproperties
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetScriptProperties(DWRITE_SCRIPT_ANALYSIS scriptAnalysis, out DWRITE_SCRIPT_PROPERTIES scriptProperties);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_1/nf-dwrite_1-idwritetextanalyzer1-gettextcomplexity
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTextComplexity([MarshalUsing(CountElementName = nameof(textLength))] PWSTR textString, uint textLength, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteFontFace>))] IDWriteFontFace fontFace, out BOOL isTextSimple, ref uint textLengthRead, nint /* optional ushort* */ glyphIndices);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_1/nf-dwrite_1-idwritetextanalyzer1-getjustificationopportunities
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetJustificationOpportunities([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteFontFace?>))] IDWriteFontFace? fontFace, float fontEmSize, DWRITE_SCRIPT_ANALYSIS scriptAnalysis, uint textLength, uint glyphCount, [MarshalUsing(CountElementName = nameof(textLength))] PWSTR textString, [In][MarshalUsing(CountElementName = nameof(textLength))] ushort[] clusterMap, [In][MarshalUsing(CountElementName = nameof(glyphCount))] DWRITE_SHAPING_GLYPH_PROPERTIES[] glyphProperties, [In][Out][MarshalUsing(CountElementName = nameof(glyphCount))] DWRITE_JUSTIFICATION_OPPORTUNITY[] justificationOpportunities);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_1/nf-dwrite_1-idwritetextanalyzer1-justifyglyphadvances
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT JustifyGlyphAdvances(float lineWidth, uint glyphCount, [In][MarshalUsing(CountElementName = nameof(glyphCount))] DWRITE_JUSTIFICATION_OPPORTUNITY[] justificationOpportunities, [In][MarshalUsing(CountElementName = nameof(glyphCount))] float[] glyphAdvances, [In][MarshalUsing(CountElementName = nameof(glyphCount))] DWRITE_GLYPH_OFFSET[] glyphOffsets, [In][Out][MarshalUsing(CountElementName = nameof(glyphCount))] float[] justifiedGlyphAdvances, nint /* optional DWRITE_GLYPH_OFFSET* */ justifiedGlyphOffsets);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_1/nf-dwrite_1-idwritetextanalyzer1-getjustifiedglyphs
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetJustifiedGlyphs([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteFontFace?>))] IDWriteFontFace? fontFace, float fontEmSize, DWRITE_SCRIPT_ANALYSIS scriptAnalysis, uint textLength, uint glyphCount, uint maxGlyphCount, nint /* optional ushort* */ clusterMap, [In][MarshalUsing(CountElementName = nameof(glyphCount))] ushort[] glyphIndices, [In][MarshalUsing(CountElementName = nameof(glyphCount))] float[] glyphAdvances, [In][MarshalUsing(CountElementName = nameof(glyphCount))] float[] justifiedGlyphAdvances, [In][MarshalUsing(CountElementName = nameof(glyphCount))] DWRITE_GLYPH_OFFSET[] justifiedGlyphOffsets, [In][MarshalUsing(CountElementName = nameof(glyphCount))] DWRITE_SHAPING_GLYPH_PROPERTIES[] glyphProperties, ref uint actualGlyphCount, nint /* optional ushort* */ modifiedClusterMap, [In][Out][MarshalUsing(CountElementName = nameof(maxGlyphCount))] ushort[] modifiedGlyphIndices, [In][Out][MarshalUsing(CountElementName = nameof(maxGlyphCount))] float[] modifiedGlyphAdvances, [In][Out][MarshalUsing(CountElementName = nameof(maxGlyphCount))] DWRITE_GLYPH_OFFSET[] modifiedGlyphOffsets);
}
