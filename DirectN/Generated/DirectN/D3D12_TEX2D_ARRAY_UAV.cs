﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_tex2d_array_uav
public partial struct D3D12_TEX2D_ARRAY_UAV
{
    public uint MipSlice;
    public uint FirstArraySlice;
    public uint ArraySize;
    public uint PlaneSlice;
}
