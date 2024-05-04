﻿#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DDHAL_GETVPORTBANDWIDTHDATA
{
    public nint lpDD;
    public nint lpVideoPort;
    public nint lpddpfFormat;
    public uint dwWidth;
    public uint dwHeight;
    public uint dwFlags;
    public nint lpBandwidth;
    public HRESULT ddRVal;
    public nint GetVideoPortBandwidth;
}
