namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-emrsetcoloradjustment
[StructLayout(LayoutKind.Sequential)]
public partial struct EMRSETCOLORADJUSTMENT
{
    public EMR emr;
    public COLORADJUSTMENT ColorAdjustment;
}
