namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-extlogpen
[StructLayout(LayoutKind.Sequential)]
public partial struct EXTLOGPEN
{
    public uint elpPenStyle;
    public uint elpWidth;
    public uint elpBrushStyle;
    public COLORREF elpColor;
    public nuint elpHatch;
    public uint elpNumEntries;
    public InlineArrayUInt321 elpStyleEntry; // variable-length array placeholder
}
