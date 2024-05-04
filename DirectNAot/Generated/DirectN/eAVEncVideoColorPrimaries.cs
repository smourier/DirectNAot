#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/codecapi/ne-codecapi-eavencvideocolorprimaries
public enum eAVEncVideoColorPrimaries
{
    eAVEncVideoColorPrimaries_SameAsSource = 0,
    eAVEncVideoColorPrimaries_Reserved = 1,
    eAVEncVideoColorPrimaries_BT709 = 2,
    eAVEncVideoColorPrimaries_BT470_2_SysM = 3,
    eAVEncVideoColorPrimaries_BT470_2_SysBG = 4,
    eAVEncVideoColorPrimaries_SMPTE170M = 5,
    eAVEncVideoColorPrimaries_SMPTE240M = 6,
    eAVEncVideoColorPrimaries_EBU3231 = 7,
    eAVEncVideoColorPrimaries_SMPTE_C = 8,
}
