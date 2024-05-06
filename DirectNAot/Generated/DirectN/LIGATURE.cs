#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct LIGATURE
{
    public uint culSize;
    public PWSTR pwsz;
    public uint chglyph;
    public InlineArrayUInt32_1 ahglyph; // variable-length array placeholder
}
