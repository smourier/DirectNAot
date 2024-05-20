#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-ciexyz
[StructLayout(LayoutKind.Sequential)]
public partial struct CIEXYZ
{
    public int ciexyzX;
    public int ciexyzY;
    public int ciexyzZ;
}
