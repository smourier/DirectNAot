namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-emrsetviewportorgex
[StructLayout(LayoutKind.Sequential)]
public partial struct EMRSETVIEWPORTORGEX
{
    public EMR emr;
    public POINTL ptlOrigin;
}
