namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct UFF_FONTDIRECTORY
{
    public uint dwSignature;
    public ushort wSize;
    public ushort wFontID;
    public short sGlyphID;
    public ushort wFlags;
    public uint dwInstallerSig;
    public uint offFontName;
    public uint offCartridgeName;
    public uint offFontData;
    public uint offGlyphData;
    public uint offVarData;
}
