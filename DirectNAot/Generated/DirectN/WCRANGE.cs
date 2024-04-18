namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-wcrange
[StructLayout(LayoutKind.Sequential)]
public partial struct WCRANGE
{
    public char wcLow;
    public ushort cGlyphs;
}
