﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawint/ns-ddrawint-dd_setoverlaypositiondata
public partial struct DD_SETOVERLAYPOSITIONDATA
{
    public nint lpDD;
    public nint lpDDSrcSurface;
    public nint lpDDDestSurface;
    public int lXPos;
    public int lYPos;
    public HRESULT ddRVal;
    public nint SetOverlayPosition;
}
