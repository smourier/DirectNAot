#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winddi/ns-winddi-colorinfo
public partial struct COLORINFO
{
    public CIECHROMA Red;
    public CIECHROMA Green;
    public CIECHROMA Blue;
    public CIECHROMA Cyan;
    public CIECHROMA Magenta;
    public CIECHROMA Yellow;
    public CIECHROMA AlignmentWhite;
    public int RedGamma;
    public int GreenGamma;
    public int BlueGamma;
    public int MagentaInCyanDye;
    public int YellowInCyanDye;
    public int CyanInMagentaDye;
    public int YellowInMagentaDye;
    public int CyanInYellowDye;
    public int MagentaInYellowDye;
}
