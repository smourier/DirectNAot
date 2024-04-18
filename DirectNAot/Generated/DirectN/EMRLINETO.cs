namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-emrlineto
[StructLayout(LayoutKind.Sequential)]
public partial struct EMRLINETO
{
    public EMR emr;
    public POINTL ptl;
}
