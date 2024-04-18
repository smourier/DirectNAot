namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-ttpolycurve
[StructLayout(LayoutKind.Sequential)]
public partial struct TTPOLYCURVE
{
    public ushort wType;
    public ushort cpfx;
    public InlineArrayPOINTFX1 apfx; // variable-length array placeholder
}
