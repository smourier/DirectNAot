﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfobjects/ne-mfobjects-mfvideochromasubsampling
public enum MFVideoChromaSubsampling
{
    MFVideoChromaSubsampling_Unknown = 0,
    MFVideoChromaSubsampling_ProgressiveChroma = 8,
    MFVideoChromaSubsampling_Horizontally_Cosited = 4,
    MFVideoChromaSubsampling_Vertically_Cosited = 2,
    MFVideoChromaSubsampling_Vertically_AlignedChromaPlanes = 1,
    MFVideoChromaSubsampling_MPEG2 = 5,
    MFVideoChromaSubsampling_MPEG1 = 1,
    MFVideoChromaSubsampling_DV_PAL = 6,
    MFVideoChromaSubsampling_Cosited = 7,
    MFVideoChromaSubsampling_Last = 8,
    MFVideoChromaSubsampling_ForceDWORD = 2147483647,
}
