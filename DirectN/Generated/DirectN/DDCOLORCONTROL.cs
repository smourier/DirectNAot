#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddraw/ns-ddraw-ddcolorcontrol
public partial struct DDCOLORCONTROL
{
    public uint dwSize;
    public uint dwFlags;
    public int lBrightness;
    public int lContrast;
    public int lHue;
    public int lSaturation;
    public int lSharpness;
    public int lGamma;
    public int lColorEnable;
    public uint dwReserved1;
}
