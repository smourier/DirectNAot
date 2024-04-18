namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-emrcreatepalette
[StructLayout(LayoutKind.Sequential)]
public partial struct EMRCREATEPALETTE
{
    public EMR emr;
    public uint ihPal;
    public LOGPALETTE lgpl;
}
