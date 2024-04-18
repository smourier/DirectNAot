namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct MAPTABLE
{
    public uint dwSize;
    public uint dwGlyphNum;
    public InlineArrayTRANSDATA1 Trans; // variable-length array placeholder
}
