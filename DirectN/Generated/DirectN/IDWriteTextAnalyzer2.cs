#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/DirectWrite/idwritetextanalyzer2
[SupportedOSPlatform("windows8.1")]
[GeneratedComInterface, Guid("553a9ff3-5693-4df7-b52b-74806f7f2eb9")]
public partial interface IDWriteTextAnalyzer2 : IDWriteTextAnalyzer1
{
    // https://learn.microsoft.com/windows/win32/api/dwrite_2/nf-dwrite_2-idwritetextanalyzer2-getglyphorientationtransform
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetGlyphOrientationTransform(DWRITE_GLYPH_ORIENTATION_ANGLE glyphOrientationAngle, BOOL isSideways, float originX, float originY, out DWRITE_MATRIX transform);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_2/nf-dwrite_2-idwritetextanalyzer2-gettypographicfeatures
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTypographicFeatures(IDWriteFontFace fontFace, DWRITE_SCRIPT_ANALYSIS scriptAnalysis, PWSTR localeName, uint maxTagCount, out uint actualTagCount, [In][Out][MarshalUsing(CountElementName = nameof(maxTagCount))] DWRITE_FONT_FEATURE_TAG[] tags);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_2/nf-dwrite_2-idwritetextanalyzer2-checktypographicfeature
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CheckTypographicFeature(IDWriteFontFace fontFace, DWRITE_SCRIPT_ANALYSIS scriptAnalysis, PWSTR localeName, DWRITE_FONT_FEATURE_TAG featureTag, uint glyphCount, [In][MarshalUsing(CountElementName = nameof(glyphCount))] ushort[] glyphIndices, nint /* byte array */ featureApplies);
}
