namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-emrpolypolyline16
[StructLayout(LayoutKind.Sequential)]
public partial struct EMRPOLYPOLYLINE16
{
    public EMR emr;
    public RECTL rclBounds;
    public uint nPolys;
    public uint cpts;
    public InlineArrayUInt321 aPolyCounts;
    public InlineArrayPOINTS1 apts; // variable-length array placeholder
}
