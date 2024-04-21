namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1_3/nn-d2d1_3-id2d1devicecontext4
[GeneratedComInterface, Guid("8c427831-3d90-4476-b647-c4fae349e4db")]
public partial interface ID2D1DeviceContext4 : ID2D1DeviceContext3
{
    // https://learn.microsoft.com/windows/win32/api/d2d1_3/nf-d2d1_3-id2d1devicecontext4-createsvgglyphstyle
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateSvgGlyphStyle(out ID2D1SvgGlyphStyle svgGlyphStyle);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_3/nf-d2d1_3-id2d1devicecontext4-drawtext(constwchar_uint32_idwritetextformat_constd2d1_rect_f_id2d1brush_id2d1svgglyphstyle_uint32_d2d1_draw_text_options_dwrite_measuring_mode)
    [PreserveSig]
    void DrawText(PWSTR @string, uint stringLength, IDWriteTextFormat textFormat, in D2D_RECT_F layoutRect, ID2D1Brush? defaultFillBrush, ID2D1SvgGlyphStyle? svgGlyphStyle, uint colorPaletteIndex, D2D1_DRAW_TEXT_OPTIONS options, DWRITE_MEASURING_MODE measuringMode);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_3/nf-d2d1_3-id2d1devicecontext4-drawtextlayout
    [PreserveSig]
    void DrawTextLayout(D2D_POINT_2F origin, IDWriteTextLayout textLayout, ID2D1Brush? defaultFillBrush, ID2D1SvgGlyphStyle? svgGlyphStyle, uint colorPaletteIndex, D2D1_DRAW_TEXT_OPTIONS options);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_3/nf-d2d1_3-id2d1devicecontext4-drawcolorbitmapglyphrun
    [PreserveSig]
    void DrawColorBitmapGlyphRun(DWRITE_GLYPH_IMAGE_FORMATS glyphImageFormat, D2D_POINT_2F baselineOrigin, in DWRITE_GLYPH_RUN glyphRun, DWRITE_MEASURING_MODE measuringMode, D2D1_COLOR_BITMAP_GLYPH_SNAP_OPTION bitmapSnapOption);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_3/nf-d2d1_3-id2d1devicecontext4-drawsvgglyphrun
    [PreserveSig]
    void DrawSvgGlyphRun(D2D_POINT_2F baselineOrigin, in DWRITE_GLYPH_RUN glyphRun, ID2D1Brush? defaultFillBrush, ID2D1SvgGlyphStyle? svgGlyphStyle, uint colorPaletteIndex, DWRITE_MEASURING_MODE measuringMode);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_3/nf-d2d1_3-id2d1devicecontext4-getcolorbitmapglyphimage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetColorBitmapGlyphImage(DWRITE_GLYPH_IMAGE_FORMATS glyphImageFormat, D2D_POINT_2F glyphOrigin, IDWriteFontFace fontFace, float fontEmSize, ushort glyphIndex, [MarshalAs(UnmanagedType.U4)] bool isSideways, nint /* optional D2D_MATRIX_3X2_F */ worldTransform, float dpiX, float dpiY, out D2D_MATRIX_3X2_F glyphTransform, out ID2D1Image glyphImage);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_3/nf-d2d1_3-id2d1devicecontext4-getsvgglyphimage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSvgGlyphImage(D2D_POINT_2F glyphOrigin, IDWriteFontFace fontFace, float fontEmSize, ushort glyphIndex, [MarshalAs(UnmanagedType.U4)] bool isSideways, nint /* optional D2D_MATRIX_3X2_F */ worldTransform, ID2D1Brush? defaultFillBrush, ID2D1SvgGlyphStyle? svgGlyphStyle, uint colorPaletteIndex, out D2D_MATRIX_3X2_F glyphTransform, out ID2D1CommandList glyphImage);
}
