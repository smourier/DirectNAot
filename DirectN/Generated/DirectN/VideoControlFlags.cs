#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/ne-strmif-videocontrolflags
public enum VideoControlFlags
{
    VideoControlFlag_FlipHorizontal = 1,
    VideoControlFlag_FlipVertical = 2,
    VideoControlFlag_ExternalTriggerEnable = 4,
    VideoControlFlag_Trigger = 8,
}
