namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-emrsetmiterlimit
[StructLayout(LayoutKind.Sequential)]
public partial struct EMRSETMITERLIMIT
{
    public EMR emr;
    public float eMiterLimit;
}
