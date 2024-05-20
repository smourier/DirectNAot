#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/ns-wmsdkidl-drm_video_output_protection_ids
[StructLayout(LayoutKind.Sequential)]
public partial struct DRM_VIDEO_OUTPUT_PROTECTION_IDS
{
    public ushort cEntries;
    public nint rgVop;
}
