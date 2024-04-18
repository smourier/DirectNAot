namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct WIDTHRUN
{
    public ushort wStartGlyph;
    public ushort wGlyphCount;
    public uint loCharWidthOffset;
}
