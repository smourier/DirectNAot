﻿#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DDHAL_QUERYMOCOMPSTATUSDATA
{
    public nint lpDD;
    public nint lpMoComp;
    public nint lpSurface;
    public uint dwFlags;
    public HRESULT ddRVal;
    public nint QueryMoCompStatus;
}