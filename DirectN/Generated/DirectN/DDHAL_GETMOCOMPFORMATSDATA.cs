﻿#nullable enable
namespace DirectN;

public partial struct DDHAL_GETMOCOMPFORMATSDATA
{
    public nint lpDD;
    public nint lpGuid;
    public uint dwNumFormats;
    public nint lpFormats;
    public HRESULT ddRVal;
    public nint GetMoCompFormats;
}
