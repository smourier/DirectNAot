namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite_2/ns-dwrite_2-dwrite_color_glyph_run
[StructLayout(LayoutKind.Sequential)]
public partial struct DWRITE_COLOR_GLYPH_RUN
{
    public DWRITE_GLYPH_RUN glyphRun;
    public nint glyphRunDescription;
    public float baselineOriginX;
    public float baselineOriginY;
    public DWRITE_COLOR_F runColor;
    public ushort paletteIndex;
}
