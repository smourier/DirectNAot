#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/ne-strmif-vmrmixerprefs
public enum VMRMixerPrefs
{
    MixerPref_NoDecimation = 1,
    MixerPref_DecimateOutput = 2,
    MixerPref_ARAdjustXorY = 4,
    MixerPref_DecimationReserved = 8,
    MixerPref_DecimateMask = 15,
    MixerPref_BiLinearFiltering = 16,
    MixerPref_PointFiltering = 32,
    MixerPref_FilteringMask = 240,
    MixerPref_RenderTargetRGB = 256,
    MixerPref_RenderTargetYUV = 4096,
    MixerPref_RenderTargetYUV420 = 512,
    MixerPref_RenderTargetYUV422 = 1024,
    MixerPref_RenderTargetYUV444 = 2048,
    MixerPref_RenderTargetReserved = 57344,
    MixerPref_RenderTargetMask = 65280,
    MixerPref_DynamicSwitchToBOB = 65536,
    MixerPref_DynamicDecimateBy2 = 131072,
    MixerPref_DynamicReserved = 786432,
    MixerPref_DynamicMask = 983040,
}
