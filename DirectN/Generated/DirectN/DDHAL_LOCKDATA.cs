﻿#nullable enable
namespace DirectN;

public partial struct DDHAL_LOCKDATA
{
    public nint lpDD;
    public nint lpDDSurface;
    public uint bHasRect;
    public RECTL rArea;
    public nint lpSurfData;
    public HRESULT ddRVal;
    public nint Lock;
    public uint dwFlags;
}
