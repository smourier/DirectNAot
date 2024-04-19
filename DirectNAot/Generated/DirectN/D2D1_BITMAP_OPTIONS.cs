namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1_1/ne-d2d1_1-d2d1_bitmap_options
[Flags]
public enum D2D1_BITMAP_OPTIONS
{
    D2D1_BITMAP_OPTIONS_NONE = 0,
    D2D1_BITMAP_OPTIONS_TARGET = 1,
    D2D1_BITMAP_OPTIONS_CANNOT_DRAW = 2,
    D2D1_BITMAP_OPTIONS_CPU_READ = 4,
    D2D1_BITMAP_OPTIONS_GDI_COMPATIBLE = 8,
}
