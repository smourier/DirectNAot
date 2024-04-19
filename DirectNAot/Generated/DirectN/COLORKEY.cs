namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/ns-strmif-colorkey
[StructLayout(LayoutKind.Sequential)]
public partial struct COLORKEY
{
    public uint KeyType;
    public uint PaletteIndex;
    public COLORREF LowColorValue;
    public COLORREF HighColorValue;
}
