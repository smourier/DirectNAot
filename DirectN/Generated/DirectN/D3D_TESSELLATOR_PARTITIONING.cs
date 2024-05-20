﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3dcommon/ne-d3dcommon-d3d_tessellator_partitioning
public enum D3D_TESSELLATOR_PARTITIONING
{
    D3D_TESSELLATOR_PARTITIONING_UNDEFINED = 0,
    D3D_TESSELLATOR_PARTITIONING_INTEGER = 1,
    D3D_TESSELLATOR_PARTITIONING_POW2 = 2,
    D3D_TESSELLATOR_PARTITIONING_FRACTIONAL_ODD = 3,
    D3D_TESSELLATOR_PARTITIONING_FRACTIONAL_EVEN = 4,
    D3D11_TESSELLATOR_PARTITIONING_UNDEFINED = 0,
    D3D11_TESSELLATOR_PARTITIONING_INTEGER = 1,
    D3D11_TESSELLATOR_PARTITIONING_POW2 = 2,
    D3D11_TESSELLATOR_PARTITIONING_FRACTIONAL_ODD = 3,
    D3D11_TESSELLATOR_PARTITIONING_FRACTIONAL_EVEN = 4,
}
