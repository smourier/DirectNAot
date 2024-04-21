﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ns-d3d11-d3d11_tex3d_rtv
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D11_TEX3D_RTV
{
    public uint MipSlice;
    public uint FirstWSlice;
    public uint WSize;
}