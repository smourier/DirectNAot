﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite/ne-dwrite-dwrite_rendering_mode
public enum DWRITE_RENDERING_MODE
{
    DWRITE_RENDERING_MODE_DEFAULT = 0,
    DWRITE_RENDERING_MODE_ALIASED = 1,
    DWRITE_RENDERING_MODE_GDI_CLASSIC = 2,
    DWRITE_RENDERING_MODE_GDI_NATURAL = 3,
    DWRITE_RENDERING_MODE_NATURAL = 4,
    DWRITE_RENDERING_MODE_NATURAL_SYMMETRIC = 5,
    DWRITE_RENDERING_MODE_OUTLINE = 6,
    DWRITE_RENDERING_MODE_CLEARTYPE_GDI_CLASSIC = 2,
    DWRITE_RENDERING_MODE_CLEARTYPE_GDI_NATURAL = 3,
    DWRITE_RENDERING_MODE_CLEARTYPE_NATURAL = 4,
    DWRITE_RENDERING_MODE_CLEARTYPE_NATURAL_SYMMETRIC = 5,
}
