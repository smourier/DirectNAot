﻿namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DirectShowDXVA2_VIDEOSAMPLE
{
    public long Start;
    public long End;
    public DXVA2_ExtendedFormat SampleFormat;
    public uint SampleFlags;
    public nint SrcResource;
    public FoundationRECT SrcRect;
    public FoundationRECT DstRect;
    public InlineArrayDXVA2_AYUVSample816 Pal;
    public DXVA2_Fixed32 PlanarAlpha;
}