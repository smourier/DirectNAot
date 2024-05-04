#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwmapi/ne-dwmapi-dwm_showcontact
[Flags]
public enum DWM_SHOWCONTACT : uint
{
    DWMSC_DOWN = 1,
    DWMSC_UP = 2,
    DWMSC_DRAG = 4,
    DWMSC_HOLD = 8,
    DWMSC_PENBARREL = 16,
    DWMSC_NONE = 0,
    DWMSC_ALL = uint.MaxValue,
}
