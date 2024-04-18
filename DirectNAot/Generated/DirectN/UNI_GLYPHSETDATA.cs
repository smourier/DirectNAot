namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct UNI_GLYPHSETDATA
{
    public uint dwSize;
    public uint dwVersion;
    public uint dwFlags;
    public int lPredefinedID;
    public uint dwGlyphCount;
    public uint dwRunCount;
    public uint loRunOffset;
    public uint dwCodePageCount;
    public uint loCodePageOffset;
    public uint loMapTableOffset;
    public InlineArrayUInt322 dwReserved;
}
