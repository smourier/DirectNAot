namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite/nn-dwrite-idwritetextrenderer
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("ef8a8135-5cc6-45fe-8825-c5a0724eb819")]
public partial interface IDWriteTextRenderer : IDWritePixelSnapping
{
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritetextrenderer-drawglyphrun
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DrawGlyphRun(nint /* optional void* */ clientDrawingContext, float baselineOriginX, float baselineOriginY, DWRITE_MEASURING_MODE measuringMode, in DWRITE_GLYPH_RUN glyphRun, in DWRITE_GLYPH_RUN_DESCRIPTION glyphRunDescription, nint clientDrawingEffect);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritetextrenderer-drawunderline
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DrawUnderline(nint /* optional void* */ clientDrawingContext, float baselineOriginX, float baselineOriginY, in DWRITE_UNDERLINE underline, nint clientDrawingEffect);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritetextrenderer-drawstrikethrough
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DrawStrikethrough(nint /* optional void* */ clientDrawingContext, float baselineOriginX, float baselineOriginY, in DWRITE_STRIKETHROUGH strikethrough, nint clientDrawingEffect);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritetextrenderer-drawinlineobject
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DrawInlineObject(nint /* optional void* */ clientDrawingContext, float originX, float originY, IDWriteInlineObject inlineObject, [MarshalAs(UnmanagedType.U4)] bool isSideways, [MarshalAs(UnmanagedType.U4)] bool isRightToLeft, nint clientDrawingEffect);
}
