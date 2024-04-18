namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-paletteentry
[StructLayout(LayoutKind.Sequential)]
public partial struct PALETTEENTRY
{
    public byte peRed;
    public byte peGreen;
    public byte peBlue;
    public byte peFlags;
}
