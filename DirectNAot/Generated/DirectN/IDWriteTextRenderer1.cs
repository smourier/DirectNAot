namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite_2/nn-dwrite_2-idwritetextrenderer1
[SupportedOSPlatform("windows8.1")]
[GeneratedComInterface, Guid("d3e0e934-22a0-427e-aae4-7d9574b59db1")]
public partial interface IDWriteTextRenderer1 : IDWriteTextRenderer
{
    // https://learn.microsoft.com/windows/win32/api/dwrite_2/nf-dwrite_2-idwritetextrenderer1-drawglyphrun
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DrawGlyphRun(nint/* nint */ clientDrawingContext, float baselineOriginX, float baselineOriginY, DWRITE_GLYPH_ORIENTATION_ANGLE orientationAngle, DWRITE_MEASURING_MODE measuringMode, in DWRITE_GLYPH_RUN glyphRun, in DWRITE_GLYPH_RUN_DESCRIPTION glyphRunDescription, nint clientDrawingEffect);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_2/nf-dwrite_2-idwritetextrenderer1-drawunderline
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DrawUnderline(nint/* nint */ clientDrawingContext, float baselineOriginX, float baselineOriginY, DWRITE_GLYPH_ORIENTATION_ANGLE orientationAngle, in DWRITE_UNDERLINE underline, nint clientDrawingEffect);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_2/nf-dwrite_2-idwritetextrenderer1-drawstrikethrough
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DrawStrikethrough(nint/* nint */ clientDrawingContext, float baselineOriginX, float baselineOriginY, DWRITE_GLYPH_ORIENTATION_ANGLE orientationAngle, in DWRITE_STRIKETHROUGH strikethrough, nint clientDrawingEffect);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_2/nf-dwrite_2-idwritetextrenderer1-drawinlineobject
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DrawInlineObject(nint/* nint */ clientDrawingContext, float originX, float originY, DWRITE_GLYPH_ORIENTATION_ANGLE orientationAngle, IDWriteInlineObject inlineObject, [MarshalAs(UnmanagedType.U4)] bool isSideways, [MarshalAs(UnmanagedType.U4)] bool isRightToLeft, nint clientDrawingEffect);
}
