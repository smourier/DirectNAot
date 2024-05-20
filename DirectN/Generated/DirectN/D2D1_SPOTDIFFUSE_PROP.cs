﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1effects/ne-d2d1effects-d2d1_spotdiffuse_prop
public enum D2D1_SPOTDIFFUSE_PROP
{
    D2D1_SPOTDIFFUSE_PROP_LIGHT_POSITION = 0,
    D2D1_SPOTDIFFUSE_PROP_POINTS_AT = 1,
    D2D1_SPOTDIFFUSE_PROP_FOCUS = 2,
    D2D1_SPOTDIFFUSE_PROP_LIMITING_CONE_ANGLE = 3,
    D2D1_SPOTDIFFUSE_PROP_DIFFUSE_CONSTANT = 4,
    D2D1_SPOTDIFFUSE_PROP_SURFACE_SCALE = 5,
    D2D1_SPOTDIFFUSE_PROP_COLOR = 6,
    D2D1_SPOTDIFFUSE_PROP_KERNEL_UNIT_LENGTH = 7,
    D2D1_SPOTDIFFUSE_PROP_SCALE_MODE = 8,
}
