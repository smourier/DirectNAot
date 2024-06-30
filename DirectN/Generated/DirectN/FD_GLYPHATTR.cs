#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winddi/ns-winddi-fd_glyphattr
public partial struct FD_GLYPHATTR
{
    public uint cjThis;
    public uint cGlyphs;
    public uint iMode;
    public InlineArrayByte_1 aGlyphAttr; // variable-length array placeholder
}
