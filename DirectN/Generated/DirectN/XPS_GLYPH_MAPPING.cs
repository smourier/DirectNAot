#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/ns-xpsobjectmodel-xps_glyph_mapping
[StructLayout(LayoutKind.Sequential)]
public partial struct XPS_GLYPH_MAPPING
{
    public uint unicodeStringStart;
    public ushort unicodeStringLength;
    public uint glyphIndicesStart;
    public ushort glyphIndicesLength;
}
