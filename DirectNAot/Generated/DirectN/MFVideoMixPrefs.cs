namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/evr/ne-evr-mfvideomixprefs
public enum MFVideoMixPrefs
{
    MFVideoMixPrefs_ForceHalfInterlace = 1,
    MFVideoMixPrefs_AllowDropToHalfInterlace = 2,
    MFVideoMixPrefs_AllowDropToBob = 4,
    MFVideoMixPrefs_ForceBob = 8,
    MFVideoMixPrefs_EnableRotation = 16,
    MFVideoMixPrefs_Mask = 31,
}
