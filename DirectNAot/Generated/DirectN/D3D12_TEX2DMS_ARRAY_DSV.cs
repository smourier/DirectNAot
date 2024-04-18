﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_tex2dms_array_dsv
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_TEX2DMS_ARRAY_DSV
{
    public uint FirstArraySlice;
    public uint ArraySize;
}
