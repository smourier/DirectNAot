#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-rgbtriple
[StructLayout(LayoutKind.Sequential)]
public partial struct RGBTRIPLE
{
    public byte rgbtBlue;
    public byte rgbtGreen;
    public byte rgbtRed;
}
