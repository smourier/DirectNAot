namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-emrfillpath
[StructLayout(LayoutKind.Sequential)]
public partial struct EMRFILLPATH
{
    public EMR emr;
    public RECTL rclBounds;
}
