﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1effects/ne-d2d1effects-d2d1_3dperspectivetransform_interpolation_mode
public enum D2D1_3DPERSPECTIVETRANSFORM_INTERPOLATION_MODE
{
    D2D1_3DPERSPECTIVETRANSFORM_INTERPOLATION_MODE_NEAREST_NEIGHBOR = 0,
    D2D1_3DPERSPECTIVETRANSFORM_INTERPOLATION_MODE_LINEAR = 1,
    D2D1_3DPERSPECTIVETRANSFORM_INTERPOLATION_MODE_CUBIC = 2,
    D2D1_3DPERSPECTIVETRANSFORM_INTERPOLATION_MODE_MULTI_SAMPLE_LINEAR = 3,
    D2D1_3DPERSPECTIVETRANSFORM_INTERPOLATION_MODE_ANISOTROPIC = 4,
}
