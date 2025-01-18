#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-paletteentry
public partial struct PALETTEENTRY
{
    public byte peRed;
    public byte peGreen;
    public byte peBlue;
    public byte peFlags;
}
