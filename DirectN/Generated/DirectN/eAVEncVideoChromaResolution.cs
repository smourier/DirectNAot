#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/codecapi/ne-codecapi-eavencvideochromaresolution
public enum eAVEncVideoChromaResolution
{
    eAVEncVideoChromaResolution_SameAsSource = 0,
    eAVEncVideoChromaResolution_444 = 1,
    eAVEncVideoChromaResolution_422 = 2,
    eAVEncVideoChromaResolution_420 = 3,
    eAVEncVideoChromaResolution_411 = 4,
}
