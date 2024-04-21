﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxva2api/ns-dxva2api-dxva2_videosample
[StructLayout(LayoutKind.Sequential)]
public partial struct MediaFoundationDXVA2_VideoSample
{
    public long Start;
    public long End;
    public DXVA2_ExtendedFormat SampleFormat;
    public nint SrcSurface;
    public FoundationRECT SrcRect;
    public FoundationRECT DstRect;
    public InlineArrayDXVA2_AYUVSample816 Pal;
    public DXVA2_Fixed32 PlanarAlpha;
    public uint SampleData;
}