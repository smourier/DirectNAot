namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-emrselectpalette
[StructLayout(LayoutKind.Sequential)]
public partial struct EMRSELECTPALETTE
{
    public EMR emr;
    public uint ihPal;
}
