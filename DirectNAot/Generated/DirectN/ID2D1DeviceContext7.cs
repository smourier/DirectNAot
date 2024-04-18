﻿namespace DirectN;

[GeneratedComInterface, Guid("ec891cf7-9b69-4851-9def-4e0915771e62")]
public partial interface ID2D1DeviceContext7 : ID2D1DeviceContext6
{
    [PreserveSig]
    public Direct2DDWRITE_PAINT_FEATURE_LEVEL GetPaintFeatureLevel();
    
    [PreserveSig]
    public void DrawPaintGlyphRun(D2D_POINT_2F baselineOrigin, in DWRITE_GLYPH_RUN glyphRun, ID2D1Brush defaultFillBrush, uint colorPaletteIndex, DWRITE_MEASURING_MODE measuringMode);
    
    [PreserveSig]
    public void DrawGlyphRunWithColorSupport(D2D_POINT_2F baselineOrigin, in DWRITE_GLYPH_RUN glyphRun, nint/* nint */ glyphRunDescription, ID2D1Brush foregroundBrush, ID2D1SvgGlyphStyle svgGlyphStyle, uint colorPaletteIndex, DWRITE_MEASURING_MODE measuringMode, D2D1_COLOR_BITMAP_GLYPH_SNAP_OPTION bitmapSnapOption);
}
