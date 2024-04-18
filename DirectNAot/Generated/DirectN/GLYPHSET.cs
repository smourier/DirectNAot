namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-glyphset
[StructLayout(LayoutKind.Sequential)]
public partial struct GLYPHSET
{
    public uint cbThis;
    public uint flAccel;
    public uint cGlyphsSupported;
    public uint cRanges;
    public InlineArrayWCRANGE1 ranges; // variable-length array placeholder
}
