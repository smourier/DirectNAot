namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-emrexcludecliprect
[StructLayout(LayoutKind.Sequential)]
public partial struct EMREXCLUDECLIPRECT
{
    public EMR emr;
    public RECTL rclClip;
}
