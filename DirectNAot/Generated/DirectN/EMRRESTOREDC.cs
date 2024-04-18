namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-emrrestoredc
[StructLayout(LayoutKind.Sequential)]
public partial struct EMRRESTOREDC
{
    public EMR emr;
    public int iRelative;
}
