#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/vmr9/ne-vmr9-vmr9deinterlaceprefs
public enum VMR9DeinterlacePrefs
{
    DeinterlacePref9_NextBest = 1,
    DeinterlacePref9_BOB = 2,
    DeinterlacePref9_Weave = 4,
    DeinterlacePref9_Mask = 7,
}
