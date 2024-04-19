namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite_1/nn-dwrite_1-idwritetextanalysissink1
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("b0d941a0-85e7-4d8b-9fd3-5ced9934482a")]
public partial interface IDWriteTextAnalysisSink1 : IDWriteTextAnalysisSink
{
    // https://learn.microsoft.com/windows/win32/api/dwrite_1/nf-dwrite_1-idwritetextanalysissink1-setglyphorientation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetGlyphOrientation(uint textPosition, uint textLength, DWRITE_GLYPH_ORIENTATION_ANGLE glyphOrientationAngle, byte adjustedBidiLevel, [MarshalAs(UnmanagedType.U4)] bool isSideways, [MarshalAs(UnmanagedType.U4)] bool isRightToLeft);
}
