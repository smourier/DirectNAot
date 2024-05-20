#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winddi/ns-winddi-fd_glyphset
[StructLayout(LayoutKind.Sequential)]
public partial struct FD_GLYPHSET
{
    public uint cjThis;
    public uint flAccel;
    public uint cGlyphsSupported;
    public uint cRuns;
    public InlineArrayWCRUN_1 awcrun; // variable-length array placeholder
}
