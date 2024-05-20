﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10/ne-d3d10-d3d10_comparison_func
public enum D3D10_COMPARISON_FUNC
{
    D3D10_COMPARISON_NEVER = 1,
    D3D10_COMPARISON_LESS = 2,
    D3D10_COMPARISON_EQUAL = 3,
    D3D10_COMPARISON_LESS_EQUAL = 4,
    D3D10_COMPARISON_GREATER = 5,
    D3D10_COMPARISON_NOT_EQUAL = 6,
    D3D10_COMPARISON_GREATER_EQUAL = 7,
    D3D10_COMPARISON_ALWAYS = 8,
}
