﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ns-d3d11-d3d11_tex1d_array_rtv
public partial struct D3D11_TEX1D_ARRAY_RTV
{
    public uint MipSlice;
    public uint FirstArraySlice;
    public uint ArraySize;
}
