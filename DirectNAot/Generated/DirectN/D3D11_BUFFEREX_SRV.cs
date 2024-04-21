﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ns-d3d11-d3d11_bufferex_srv
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D11_BUFFEREX_SRV
{
    public uint FirstElement;
    public uint NumElements;
    public uint Flags;
}