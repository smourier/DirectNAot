#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite_3/ns-dwrite_3-dwrite_color_glyph_run1
[StructLayout(LayoutKind.Sequential)]
public partial struct DWRITE_COLOR_GLYPH_RUN1
{
    public DWRITE_COLOR_GLYPH_RUN Base;
    public DWRITE_GLYPH_IMAGE_FORMATS glyphImageFormat;
    public DWRITE_MEASURING_MODE measuringMode;
}
