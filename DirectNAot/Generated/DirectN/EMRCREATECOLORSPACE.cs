namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-emrcreatecolorspace
[StructLayout(LayoutKind.Sequential)]
public partial struct EMRCREATECOLORSPACE
{
    public EMR emr;
    public uint ihCS;
    public LOGCOLORSPACEA lcs;
}
