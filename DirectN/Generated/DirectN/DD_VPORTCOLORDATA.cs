﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawint/ns-ddrawint-dd_vportcolordata
public partial struct DD_VPORTCOLORDATA
{
    public nint lpDD;
    public nint lpVideoPort;
    public uint dwFlags;
    public nint lpColorData;
    public HRESULT ddRVal;
    public nint ColorControl;
}
