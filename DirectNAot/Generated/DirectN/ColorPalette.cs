#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct ColorPalette
{
    public uint Flags;
    public uint Count;
    public InlineArrayUInt32_1 Entries; // variable-length array placeholder
}
