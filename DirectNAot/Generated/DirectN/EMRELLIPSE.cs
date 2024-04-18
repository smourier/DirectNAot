namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-emrellipse
[StructLayout(LayoutKind.Sequential)]
public partial struct EMRELLIPSE
{
    public EMR emr;
    public RECTL rclBox;
}
