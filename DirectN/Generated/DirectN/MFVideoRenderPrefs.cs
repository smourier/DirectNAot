#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/evr/ne-evr-mfvideorenderprefs
public enum MFVideoRenderPrefs
{
    MFVideoRenderPrefs_DoNotRenderBorder = 1,
    MFVideoRenderPrefs_DoNotClipToDevice = 2,
    MFVideoRenderPrefs_AllowOutputThrottling = 4,
    MFVideoRenderPrefs_ForceOutputThrottling = 8,
    MFVideoRenderPrefs_ForceBatching = 16,
    MFVideoRenderPrefs_AllowBatching = 32,
    MFVideoRenderPrefs_ForceScaling = 64,
    MFVideoRenderPrefs_AllowScaling = 128,
    MFVideoRenderPrefs_DoNotRepaintOnStop = 256,
    MFVideoRenderPrefs_Mask = 511,
}
