#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winddi/ns-winddi-wcrun
[StructLayout(LayoutKind.Sequential)]
public partial struct WCRUN
{
    public char wcLow;
    public ushort cGlyphs;
    public nint phg;
}
