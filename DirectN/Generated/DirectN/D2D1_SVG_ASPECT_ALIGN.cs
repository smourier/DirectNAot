﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1svg/ne-d2d1svg-d2d1_svg_aspect_align
public enum D2D1_SVG_ASPECT_ALIGN
{
    D2D1_SVG_ASPECT_ALIGN_NONE = 0,
    D2D1_SVG_ASPECT_ALIGN_X_MIN_Y_MIN = 1,
    D2D1_SVG_ASPECT_ALIGN_X_MID_Y_MIN = 2,
    D2D1_SVG_ASPECT_ALIGN_X_MAX_Y_MIN = 3,
    D2D1_SVG_ASPECT_ALIGN_X_MIN_Y_MID = 4,
    D2D1_SVG_ASPECT_ALIGN_X_MID_Y_MID = 5,
    D2D1_SVG_ASPECT_ALIGN_X_MAX_Y_MID = 6,
    D2D1_SVG_ASPECT_ALIGN_X_MIN_Y_MAX = 7,
    D2D1_SVG_ASPECT_ALIGN_X_MID_Y_MAX = 8,
    D2D1_SVG_ASPECT_ALIGN_X_MAX_Y_MAX = 9,
}
