#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-psfeature_custpaper
[StructLayout(LayoutKind.Sequential)]
public partial struct PSFEATURE_CUSTPAPER
{
    public int lOrientation;
    public int lWidth;
    public int lHeight;
    public int lWidthOffset;
    public int lHeightOffset;
}
