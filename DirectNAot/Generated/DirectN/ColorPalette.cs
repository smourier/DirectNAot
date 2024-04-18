namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct ColorPalette
{
    public uint Flags;
    public uint Count;
    public InlineArrayUInt321 Entries; // variable-length array placeholder
}
