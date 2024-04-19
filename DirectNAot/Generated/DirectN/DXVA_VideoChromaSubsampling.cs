namespace DirectN;

public enum DXVA_VideoChromaSubsampling
{
    DXVA_VideoChromaSubsamplingShift = 8,
    DXVA_VideoChromaSubsamplingMask = 3840,
    DXVA_VideoChromaSubsampling_Unknown = 0,
    DXVA_VideoChromaSubsampling_ProgressiveChroma = 8,
    DXVA_VideoChromaSubsampling_Horizontally_Cosited = 4,
    DXVA_VideoChromaSubsampling_Vertically_Cosited = 2,
    DXVA_VideoChromaSubsampling_Vertically_AlignedChromaPlanes = 1,
    DXVA_VideoChromaSubsampling_MPEG2 = 5,
    DXVA_VideoChromaSubsampling_MPEG1 = 1,
    DXVA_VideoChromaSubsampling_DV_PAL = 6,
    DXVA_VideoChromaSubsampling_Cosited = 7,
}
