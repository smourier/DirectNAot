﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawint/ns-ddrawint-dd_getmocompformatsdata
public partial struct DD_GETMOCOMPFORMATSDATA
{
    public nint lpDD;
    public nint lpGuid;
    public uint dwNumFormats;
    public nint lpFormats;
    public HRESULT ddRVal;
}
