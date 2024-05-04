#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-pointfx
[StructLayout(LayoutKind.Sequential)]
public partial struct POINTFX
{
    public FIXED x;
    public FIXED y;
}
