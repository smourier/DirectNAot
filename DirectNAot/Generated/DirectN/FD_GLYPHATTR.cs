namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winddi/ns-winddi-fd_glyphattr
[StructLayout(LayoutKind.Sequential)]
public partial struct FD_GLYPHATTR
{
    public uint cjThis;
    public uint cGlyphs;
    public uint iMode;
    public InlineArrayByte1 aGlyphAttr; // variable-length array placeholder
}
