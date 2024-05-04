﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/ne-d2d1effectauthor-d2d1_filter
public enum D2D1_FILTER
{
    D2D1_FILTER_MIN_MAG_MIP_POINT = 0,
    D2D1_FILTER_MIN_MAG_POINT_MIP_LINEAR = 1,
    D2D1_FILTER_MIN_POINT_MAG_LINEAR_MIP_POINT = 4,
    D2D1_FILTER_MIN_POINT_MAG_MIP_LINEAR = 5,
    D2D1_FILTER_MIN_LINEAR_MAG_MIP_POINT = 16,
    D2D1_FILTER_MIN_LINEAR_MAG_POINT_MIP_LINEAR = 17,
    D2D1_FILTER_MIN_MAG_LINEAR_MIP_POINT = 20,
    D2D1_FILTER_MIN_MAG_MIP_LINEAR = 21,
    D2D1_FILTER_ANISOTROPIC = 85,
}
