﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winddi/ns-winddi-glyphpos
public partial struct GLYPHPOS
{
    public uint hg;
    public nint pgdf;
    public POINTL ptl;
}
