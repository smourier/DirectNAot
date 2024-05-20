#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-ciexyztriple
[StructLayout(LayoutKind.Sequential)]
public partial struct CIEXYZTRIPLE
{
    public CIEXYZ ciexyzRed;
    public CIEXYZ ciexyzGreen;
    public CIEXYZ ciexyzBlue;
}
