namespace DirectN;

public enum DXVA2_VideoProcess
{
    DXVA2_VideoProcess_None = 0,
    DXVA2_VideoProcess_YUV2RGB = 1,
    DXVA2_VideoProcess_StretchX = 2,
    DXVA2_VideoProcess_StretchY = 4,
    DXVA2_VideoProcess_AlphaBlend = 8,
    DXVA2_VideoProcess_SubRects = 16,
    DXVA2_VideoProcess_SubStreams = 32,
    DXVA2_VideoProcess_SubStreamsExtended = 64,
    DXVA2_VideoProcess_YUV2RGBExtended = 128,
    DXVA2_VideoProcess_AlphaBlendExtended = 256,
    DXVA2_VideoProcess_Constriction = 512,
    DXVA2_VideoProcess_NoiseFilter = 1024,
    DXVA2_VideoProcess_DetailFilter = 2048,
    DXVA2_VideoProcess_PlanarAlpha = 4096,
    DXVA2_VideoProcess_LinearScaling = 8192,
    DXVA2_VideoProcess_GammaCompensated = 16384,
    DXVA2_VideoProcess_MaintainsOriginalFieldData = 32768,
    DXVA2_VideoProcess_Mask = 65535,
}
