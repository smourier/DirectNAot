namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/ns-wmsdkidl-drm_copy_opl
[StructLayout(LayoutKind.Sequential)]
public partial struct DRM_COPY_OPL
{
    public ushort wMinimumCopyLevel;
    public DRM_OPL_OUTPUT_IDS oplIdIncludes;
    public DRM_OPL_OUTPUT_IDS oplIdExcludes;
}
