namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DWRITE_PAINT_COLOR
{
    public DWRITE_COLOR_F value;
    public ushort paletteEntryIndex;
    public float alphaMultiplier;
    public DWRITE_PAINT_ATTRIBUTES colorAttributes;
}
