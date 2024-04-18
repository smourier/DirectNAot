namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-emrroundrect
[StructLayout(LayoutKind.Sequential)]
public partial struct EMRROUNDRECT
{
    public EMR emr;
    public RECTL rclBox;
    public nint szlCorner;
}
