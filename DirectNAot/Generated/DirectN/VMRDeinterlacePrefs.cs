namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/ne-strmif-vmrdeinterlaceprefs
public enum VMRDeinterlacePrefs
{
    DeinterlacePref_NextBest = 1,
    DeinterlacePref_BOB = 2,
    DeinterlacePref_Weave = 4,
    DeinterlacePref_Mask = 7,
}
