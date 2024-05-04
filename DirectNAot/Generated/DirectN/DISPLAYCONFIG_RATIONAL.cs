#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-displayconfig_rational
[StructLayout(LayoutKind.Sequential)]
public partial struct DISPLAYCONFIG_RATIONAL
{
    public uint Numerator;
    public uint Denominator;
}
