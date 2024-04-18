namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite/ns-dwrite-dwrite_font_metrics
[StructLayout(LayoutKind.Sequential)]
public partial struct DWRITE_FONT_METRICS
{
    public ushort designUnitsPerEm;
    public ushort ascent;
    public ushort descent;
    public short lineGap;
    public ushort capHeight;
    public ushort xHeight;
    public short underlinePosition;
    public ushort underlineThickness;
    public short strikethroughPosition;
    public ushort strikethroughThickness;
}
