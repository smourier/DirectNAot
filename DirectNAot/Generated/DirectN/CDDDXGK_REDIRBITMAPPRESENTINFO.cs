﻿namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct CDDDXGK_REDIRBITMAPPRESENTINFO
{
    public uint NumDirtyRects;
    public FoundationRECT DirtyRect;
    public uint NumContexts;
    public InlineArrayHANDLE65 hContext;
    public BOOLEAN bDoNotSynchronizeWithDxContent;
}