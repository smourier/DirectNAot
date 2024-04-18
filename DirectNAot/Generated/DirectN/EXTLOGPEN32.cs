namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct EXTLOGPEN32
{
    public uint elpPenStyle;
    public uint elpWidth;
    public uint elpBrushStyle;
    public COLORREF elpColor;
    public uint elpHatch;
    public uint elpNumEntries;
    public InlineArrayUInt321 elpStyleEntry; // variable-length array placeholder
}
