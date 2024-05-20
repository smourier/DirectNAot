#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1/ne-d2d1-d2d1_draw_text_options
[Flags]
public enum D2D1_DRAW_TEXT_OPTIONS
{
    D2D1_DRAW_TEXT_OPTIONS_NO_SNAP = 1,
    D2D1_DRAW_TEXT_OPTIONS_CLIP = 2,
    D2D1_DRAW_TEXT_OPTIONS_ENABLE_COLOR_FONT = 4,
    D2D1_DRAW_TEXT_OPTIONS_DISABLE_COLOR_BITMAP_SNAPPING = 8,
    D2D1_DRAW_TEXT_OPTIONS_NONE = 0,
}
