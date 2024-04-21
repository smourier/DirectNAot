﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1effects_2/ne-d2d1effects_2-d2d1_straighten_scale_mode
public enum D2D1_STRAIGHTEN_SCALE_MODE
{
    D2D1_STRAIGHTEN_SCALE_MODE_NEAREST_NEIGHBOR = 0,
    D2D1_STRAIGHTEN_SCALE_MODE_LINEAR = 1,
    D2D1_STRAIGHTEN_SCALE_MODE_CUBIC = 2,
    D2D1_STRAIGHTEN_SCALE_MODE_MULTI_SAMPLE_LINEAR = 3,
    D2D1_STRAIGHTEN_SCALE_MODE_ANISOTROPIC = 4,
}