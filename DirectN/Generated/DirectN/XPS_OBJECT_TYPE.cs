﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/ne-xpsobjectmodel-xps_object_type
public enum XPS_OBJECT_TYPE
{
    XPS_OBJECT_TYPE_CANVAS = 1,
    XPS_OBJECT_TYPE_GLYPHS = 2,
    XPS_OBJECT_TYPE_PATH = 3,
    XPS_OBJECT_TYPE_MATRIX_TRANSFORM = 4,
    XPS_OBJECT_TYPE_GEOMETRY = 5,
    XPS_OBJECT_TYPE_SOLID_COLOR_BRUSH = 6,
    XPS_OBJECT_TYPE_IMAGE_BRUSH = 7,
    XPS_OBJECT_TYPE_LINEAR_GRADIENT_BRUSH = 8,
    XPS_OBJECT_TYPE_RADIAL_GRADIENT_BRUSH = 9,
    XPS_OBJECT_TYPE_VISUAL_BRUSH = 10,
}
