#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1/ne-d2d1-d2d1_window_state
[Flags]
public enum D2D1_WINDOW_STATE
{
    D2D1_WINDOW_STATE_NONE = 0,
    D2D1_WINDOW_STATE_OCCLUDED = 1,
}
