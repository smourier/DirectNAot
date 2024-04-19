namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/vmr9/ne-vmr9-vmr9mixerprefs
public enum VMR9MixerPrefs
{
    MixerPref9_NoDecimation = 1,
    MixerPref9_DecimateOutput = 2,
    MixerPref9_ARAdjustXorY = 4,
    MixerPref9_NonSquareMixing = 8,
    MixerPref9_DecimateMask = 15,
    MixerPref9_BiLinearFiltering = 16,
    MixerPref9_PointFiltering = 32,
    MixerPref9_AnisotropicFiltering = 64,
    MixerPref9_PyramidalQuadFiltering = 128,
    MixerPref9_GaussianQuadFiltering = 256,
    MixerPref9_FilteringReserved = 3584,
    MixerPref9_FilteringMask = 4080,
    MixerPref9_RenderTargetRGB = 4096,
    MixerPref9_RenderTargetYUV = 8192,
    MixerPref9_RenderTargetReserved = 1032192,
    MixerPref9_RenderTargetMask = 1044480,
    MixerPref9_DynamicSwitchToBOB = 1048576,
    MixerPref9_DynamicDecimateBy2 = 2097152,
    MixerPref9_DynamicReserved = 12582912,
    MixerPref9_DynamicMask = 15728640,
}
