namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-emrsetcolorspace
[StructLayout(LayoutKind.Sequential)]
public partial struct EMRSETCOLORSPACE
{
    public EMR emr;
    public uint ihCS;
}
