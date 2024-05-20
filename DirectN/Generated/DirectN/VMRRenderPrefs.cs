#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/ne-strmif-vmrrenderprefs
public enum VMRRenderPrefs
{
    RenderPrefs_RestrictToInitialMonitor = 0,
    RenderPrefs_ForceOffscreen = 1,
    RenderPrefs_ForceOverlays = 2,
    RenderPrefs_AllowOverlays = 0,
    RenderPrefs_AllowOffscreen = 0,
    RenderPrefs_DoNotRenderColorKeyAndBorder = 8,
    RenderPrefs_Reserved = 16,
    RenderPrefs_PreferAGPMemWhenMixing = 32,
    RenderPrefs_Mask = 63,
}
