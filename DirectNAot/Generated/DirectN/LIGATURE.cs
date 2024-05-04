#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct LIGATURE
{
    public uint culSize;
    public PWSTR pwsz;
    public uint chglyph;
    public InlineArrayUInt321 ahglyph; // variable-length array placeholder
}
