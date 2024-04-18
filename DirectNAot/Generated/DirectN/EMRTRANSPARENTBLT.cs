﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-emrtransparentblt
[StructLayout(LayoutKind.Sequential)]
public partial struct EMRTRANSPARENTBLT
{
    public EMR emr;
    public RECTL rclBounds;
    public int xDest;
    public int yDest;
    public int cxDest;
    public int cyDest;
    public uint dwRop;
    public int xSrc;
    public int ySrc;
    public XFORM xformSrc;
    public COLORREF crBkColorSrc;
    public uint iUsageSrc;
    public uint offBmiSrc;
    public uint cbBmiSrc;
    public uint offBitsSrc;
    public uint cbBitsSrc;
    public int cxSrc;
    public int cySrc;
}
