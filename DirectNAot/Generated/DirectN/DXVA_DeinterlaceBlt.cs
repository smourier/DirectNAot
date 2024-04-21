﻿namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DXVA_DeinterlaceBlt
{
    public uint Size;
    public uint Reserved;
    public long rtTarget;
    public FoundationRECT DstRect;
    public FoundationRECT SrcRect;
    public uint NumSourceSurfaces;
    public float Alpha;
    public InlineArrayDXVA_VideoSample32 Source;
}