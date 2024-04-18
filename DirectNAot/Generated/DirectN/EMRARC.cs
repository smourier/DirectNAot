namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-emrarc
[StructLayout(LayoutKind.Sequential)]
public partial struct EMRARC
{
    public EMR emr;
    public RECTL rclBox;
    public POINTL ptlStart;
    public POINTL ptlEnd;
}
