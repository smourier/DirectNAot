namespace DirectN;

public enum DXVA_VideoProcessCaps
{
    DXVA_VideoProcess_None = 0,
    DXVA_VideoProcess_YUV2RGB = 1,
    DXVA_VideoProcess_StretchX = 2,
    DXVA_VideoProcess_StretchY = 4,
    DXVA_VideoProcess_AlphaBlend = 8,
    DXVA_VideoProcess_SubRects = 16,
    DXVA_VideoProcess_SubStreams = 32,
    DXVA_VideoProcess_SubStreamsExtended = 64,
    DXVA_VideoProcess_YUV2RGBExtended = 128,
    DXVA_VideoProcess_AlphaBlendExtended = 256,
}
