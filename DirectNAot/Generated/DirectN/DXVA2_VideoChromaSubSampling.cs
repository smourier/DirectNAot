namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxva2api/ne-dxva2api-dxva2_videochromasubsampling
public enum DXVA2_VideoChromaSubSampling
{
    DXVA2_VideoChromaSubsamplingMask = 15,
    DXVA2_VideoChromaSubsampling_Unknown = 0,
    DXVA2_VideoChromaSubsampling_ProgressiveChroma = 8,
    DXVA2_VideoChromaSubsampling_Horizontally_Cosited = 4,
    DXVA2_VideoChromaSubsampling_Vertically_Cosited = 2,
    DXVA2_VideoChromaSubsampling_Vertically_AlignedChromaPlanes = 1,
    DXVA2_VideoChromaSubsampling_MPEG2 = 5,
    DXVA2_VideoChromaSubsampling_MPEG1 = 1,
    DXVA2_VideoChromaSubsampling_DV_PAL = 6,
    DXVA2_VideoChromaSubsampling_Cosited = 7,
}
