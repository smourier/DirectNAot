namespace DirectN;

[GeneratedComInterface, Guid("aeec37db-c337-40f1-8e2a-9a41b167b238")]
public partial interface IDWriteBitmapRenderTarget3 : IDWriteBitmapRenderTarget2
{
    [PreserveSig]
    public DirectWriteDWRITE_PAINT_FEATURE_LEVEL GetPaintFeatureLevel();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT DrawPaintGlyphRun(float baselineOriginX, float baselineOriginY, DWRITE_MEASURING_MODE measuringMode, in DWRITE_GLYPH_RUN glyphRun, DWRITE_GLYPH_IMAGE_FORMATS glyphImageFormat, COLORREF textColor, uint colorPaletteIndex, nint/* nint */ blackBoxRect);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT DrawGlyphRunWithColorSupport(float baselineOriginX, float baselineOriginY, DWRITE_MEASURING_MODE measuringMode, in DWRITE_GLYPH_RUN glyphRun, IDWriteRenderingParams renderingParams, COLORREF textColor, uint colorPaletteIndex, nint/* nint */ blackBoxRect);
}
