namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winddi/ns-winddi-fontinfo
[StructLayout(LayoutKind.Sequential)]
public partial struct FONTINFO
{
    public uint cjThis;
    public uint flCaps;
    public uint cGlyphsSupported;
    public uint cjMaxGlyph1;
    public uint cjMaxGlyph4;
    public uint cjMaxGlyph8;
    public uint cjMaxGlyph32;
}
