namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite_1/nn-dwrite_1-idwritetextanalysissource1
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("639cfad8-0fb4-4b21-a58a-067920120009")]
public partial interface IDWriteTextAnalysisSource1 : IDWriteTextAnalysisSource
{
    // https://learn.microsoft.com/windows/win32/api/dwrite_1/nf-dwrite_1-idwritetextanalysissource1-getverticalglyphorientation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetVerticalGlyphOrientation(uint textPosition, out uint textLength, out DWRITE_VERTICAL_GLYPH_ORIENTATION glyphOrientation, nint /* byte array */ bidiLevel);
}
