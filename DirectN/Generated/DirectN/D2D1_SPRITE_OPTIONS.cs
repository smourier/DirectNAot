#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1_3/ne-d2d1_3-d2d1_sprite_options
[Flags]
public enum D2D1_SPRITE_OPTIONS
{
    D2D1_SPRITE_OPTIONS_NONE = 0,
    D2D1_SPRITE_OPTIONS_CLAMP_TO_SOURCE_RECTANGLE = 1,
}
