namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-emrpolyline16
[StructLayout(LayoutKind.Sequential)]
public partial struct EMRPOLYLINE16
{
    public EMR emr;
    public RECTL rclBounds;
    public uint cpts;
    public InlineArrayPOINTS1 apts; // variable-length array placeholder
}
