﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10/ne-d3d10-d3d10_usage
public enum D3D10_USAGE
{
    D3D10_USAGE_DEFAULT = 0,
    D3D10_USAGE_IMMUTABLE = 1,
    D3D10_USAGE_DYNAMIC = 2,
    D3D10_USAGE_STAGING = 3,
}
