#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/ns-wmsdkidl-drm_play_opl
[StructLayout(LayoutKind.Sequential)]
public partial struct DRM_PLAY_OPL
{
    public DRM_MINIMUM_OUTPUT_PROTECTION_LEVELS minOPL;
    public DRM_OPL_OUTPUT_IDS oplIdReserved;
    public DRM_VIDEO_OUTPUT_PROTECTION_IDS vopi;
}
