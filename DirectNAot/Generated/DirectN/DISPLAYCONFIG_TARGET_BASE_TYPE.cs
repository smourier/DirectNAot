namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-displayconfig_target_base_type
[StructLayout(LayoutKind.Sequential)]
public partial struct DISPLAYCONFIG_TARGET_BASE_TYPE
{
    public DISPLAYCONFIG_DEVICE_INFO_HEADER header;
    public DISPLAYCONFIG_VIDEO_OUTPUT_TECHNOLOGY baseOutputTechnology;
}
