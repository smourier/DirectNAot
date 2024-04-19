namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/codecapi/ne-codecapi-eavencvideochromasubsampling
public enum eAVEncVideoChromaSubsampling
{
    eAVEncVideoChromaSubsamplingFormat_SameAsSource = 0,
    eAVEncVideoChromaSubsamplingFormat_ProgressiveChroma = 8,
    eAVEncVideoChromaSubsamplingFormat_Horizontally_Cosited = 4,
    eAVEncVideoChromaSubsamplingFormat_Vertically_Cosited = 2,
    eAVEncVideoChromaSubsamplingFormat_Vertically_AlignedChromaPlanes = 1,
}
