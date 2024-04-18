﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite/ne-dwrite-dwrite_font_file_type
public enum DWRITE_FONT_FILE_TYPE
{
    DWRITE_FONT_FILE_TYPE_UNKNOWN = 0,
    DWRITE_FONT_FILE_TYPE_CFF = 1,
    DWRITE_FONT_FILE_TYPE_TRUETYPE = 2,
    DWRITE_FONT_FILE_TYPE_OPENTYPE_COLLECTION = 3,
    DWRITE_FONT_FILE_TYPE_TYPE1_PFM = 4,
    DWRITE_FONT_FILE_TYPE_TYPE1_PFB = 5,
    DWRITE_FONT_FILE_TYPE_VECTOR = 6,
    DWRITE_FONT_FILE_TYPE_BITMAP = 7,
    DWRITE_FONT_FILE_TYPE_TRUETYPE_COLLECTION = 3,
}
