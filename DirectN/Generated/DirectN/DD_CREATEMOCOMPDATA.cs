﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawint/ns-ddrawint-dd_createmocompdata
public partial struct DD_CREATEMOCOMPDATA
{
    public nint lpDD;
    public nint lpMoComp;
    public nint lpGuid;
    public uint dwUncompWidth;
    public uint dwUncompHeight;
    public DDPIXELFORMAT ddUncompPixelFormat;
    public nint lpData;
    public uint dwDataSize;
    public HRESULT ddRVal;
}
