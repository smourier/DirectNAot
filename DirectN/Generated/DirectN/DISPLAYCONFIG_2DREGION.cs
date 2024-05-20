#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-displayconfig_2dregion
[StructLayout(LayoutKind.Sequential)]
public partial struct DISPLAYCONFIG_2DREGION
{
    public uint cx;
    public uint cy;
}
