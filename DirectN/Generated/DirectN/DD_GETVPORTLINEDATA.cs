﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawint/ns-ddrawint-dd_getvportlinedata
public partial struct DD_GETVPORTLINEDATA
{
    public nint lpDD;
    public nint lpVideoPort;
    public uint dwLine;
    public HRESULT ddRVal;
    public nint GetVideoPortLine;
}
