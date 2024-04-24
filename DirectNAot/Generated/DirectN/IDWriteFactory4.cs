namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite_3/nn-dwrite_3-idwritefactory4
[GeneratedComInterface, Guid("4b0b5bd3-0797-4549-8ac5-fe915cc53856")]
public partial interface IDWriteFactory4 : IDWriteFactory3
{
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefactory4-translatecolorglyphrun
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TranslateColorGlyphRun(D2D_POINT_2F baselineOrigin, in DWRITE_GLYPH_RUN glyphRun, nint /* optional DWRITE_GLYPH_RUN_DESCRIPTION* */ glyphRunDescription, DWRITE_GLYPH_IMAGE_FORMATS desiredGlyphImageFormats, DWRITE_MEASURING_MODE measuringMode, nint /* optional DWRITE_MATRIX* */ worldAndDpiTransform, uint colorPaletteIndex, out IDWriteColorGlyphRunEnumerator1 colorLayers);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefactory4-computeglyphorigins(dwrite_glyph_runconst_dwrite_measuring_mode_d2d1_point_2f_dwrite_matrixconst_d2d1_point_2f)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ComputeGlyphOrigins(in DWRITE_GLYPH_RUN glyphRun, D2D_POINT_2F baselineOrigin, out D2D_POINT_2F glyphOrigins);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefactory4-computeglyphorigins(dwrite_glyph_runconst_dwrite_measuring_mode_d2d1_point_2f_dwrite_matrixconst_d2d1_point_2f)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ComputeGlyphOrigins(in DWRITE_GLYPH_RUN glyphRun, DWRITE_MEASURING_MODE measuringMode, D2D_POINT_2F baselineOrigin, nint /* optional DWRITE_MATRIX* */ worldAndDpiTransform, out D2D_POINT_2F glyphOrigins);
}
