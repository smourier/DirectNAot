#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/ns-wmsdkidl-drm_output_protection
[StructLayout(LayoutKind.Sequential)]
public partial struct DRM_OUTPUT_PROTECTION
{
    public Guid guidId;
    public byte bConfigData;
}
