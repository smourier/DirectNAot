﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dcommon/ne-dcommon-dwrite_glyph_image_formats
[Flags]
public enum DWRITE_GLYPH_IMAGE_FORMATS
{
    DWRITE_GLYPH_IMAGE_FORMATS_NONE = 0,
    DWRITE_GLYPH_IMAGE_FORMATS_TRUETYPE = 1,
    DWRITE_GLYPH_IMAGE_FORMATS_CFF = 2,
    DWRITE_GLYPH_IMAGE_FORMATS_COLR = 4,
    DWRITE_GLYPH_IMAGE_FORMATS_SVG = 8,
    DWRITE_GLYPH_IMAGE_FORMATS_PNG = 16,
    DWRITE_GLYPH_IMAGE_FORMATS_JPEG = 32,
    DWRITE_GLYPH_IMAGE_FORMATS_TIFF = 64,
    DWRITE_GLYPH_IMAGE_FORMATS_PREMULTIPLIED_B8G8R8A8 = 128,
    DWRITE_GLYPH_IMAGE_FORMATS_COLR_PAINT_TREE = 256,
}
