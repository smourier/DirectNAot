namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1/ne-d2d1-d2d1_compatible_render_target_options
[Flags]
public enum D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS
{
    D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS_NONE = 0,
    D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS_GDI_COMPATIBLE = 1,
}
