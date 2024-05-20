#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/ns-wmsdkidl-drm_val16
[StructLayout(LayoutKind.Sequential)]
public partial struct DRM_VAL16
{
    public InlineArrayByte_16 val;
}
