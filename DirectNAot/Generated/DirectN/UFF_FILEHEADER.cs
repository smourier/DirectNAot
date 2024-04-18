namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct UFF_FILEHEADER
{
    public uint dwSignature;
    public uint dwVersion;
    public uint dwSize;
    public uint nFonts;
    public uint nGlyphSets;
    public uint nVarData;
    public uint offFontDir;
    public uint dwFlags;
    public InlineArrayUInt324 dwReserved;
}
