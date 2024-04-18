namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-emrsetviewportextex
[StructLayout(LayoutKind.Sequential)]
public partial struct EMRSETVIEWPORTEXTEX
{
    public EMR emr;
    public nint szlExtent;
}
