﻿#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("ec891cf7-9b69-4851-9def-4e0915771e62")]
public partial interface ID2D1DeviceContext7 : ID2D1DeviceContext6
{
    [PreserveSig]
    DWRITE_PAINT_FEATURE_LEVEL GetPaintFeatureLevel();
    
    [PreserveSig]
    void DrawPaintGlyphRun(D2D_POINT_2F baselineOrigin, in DWRITE_GLYPH_RUN glyphRun, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1Brush?>))] ID2D1Brush? defaultFillBrush, uint colorPaletteIndex, DWRITE_MEASURING_MODE measuringMode);
    
    [PreserveSig]
    void DrawGlyphRunWithColorSupport(D2D_POINT_2F baselineOrigin, in DWRITE_GLYPH_RUN glyphRun, nint /* optional DWRITE_GLYPH_RUN_DESCRIPTION* */ glyphRunDescription, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1Brush?>))] ID2D1Brush? foregroundBrush, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1SvgGlyphStyle?>))] ID2D1SvgGlyphStyle? svgGlyphStyle, uint colorPaletteIndex, DWRITE_MEASURING_MODE measuringMode, D2D1_COLOR_BITMAP_GLYPH_SNAP_OPTION bitmapSnapOption);
}
