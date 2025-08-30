#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-displayconfig_target_mode
public partial struct DISPLAYCONFIG_TARGET_MODE : IValueGet<DISPLAYCONFIG_VIDEO_SIGNAL_INFO>
{
    public DISPLAYCONFIG_VIDEO_SIGNAL_INFO targetVideoSignalInfo;
    
    readonly DISPLAYCONFIG_VIDEO_SIGNAL_INFO IValueGet<DISPLAYCONFIG_VIDEO_SIGNAL_INFO>.GetValue() => targetVideoSignalInfo;
    readonly object? IValueGet.GetValue() => targetVideoSignalInfo;
}
