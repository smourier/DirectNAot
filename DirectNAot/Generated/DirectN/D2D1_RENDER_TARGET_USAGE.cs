namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1/ne-d2d1-d2d1_render_target_usage
[Flags]
public enum D2D1_RENDER_TARGET_USAGE
{
    D2D1_RENDER_TARGET_USAGE_NONE = 0,
    D2D1_RENDER_TARGET_USAGE_FORCE_BITMAP_REMOTING = 1,
    D2D1_RENDER_TARGET_USAGE_GDI_COMPATIBLE = 2,
}
