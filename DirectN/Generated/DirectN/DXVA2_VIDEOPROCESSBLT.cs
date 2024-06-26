﻿#nullable enable
namespace DirectN;

public partial struct DXVA2_VIDEOPROCESSBLT
{
    public long TargetFrame;
    public RECT TargetRect;
    public SIZE ConstrictionSize;
    public uint StreamingFlags;
    public DXVA2_AYUVSample16 BackgroundColor;
    public DXVA2_ExtendedFormat DestFormat;
    public uint DestFlags;
    public DXVA2_ProcAmpValues ProcAmpValues;
    public DXVA2_Fixed32 Alpha;
    public DXVA2_FilterValues NoiseFilterLuma;
    public DXVA2_FilterValues NoiseFilterChroma;
    public DXVA2_FilterValues DetailFilterLuma;
    public DXVA2_FilterValues DetailFilterChroma;
    public nint pSrcSurfaces;
    public uint NumSrcSurfaces;
}
