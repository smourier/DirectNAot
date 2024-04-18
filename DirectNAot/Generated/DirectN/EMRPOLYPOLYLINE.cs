namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-emrpolypolyline
[StructLayout(LayoutKind.Sequential)]
public partial struct EMRPOLYPOLYLINE
{
    public EMR emr;
    public RECTL rclBounds;
    public uint nPolys;
    public uint cptl;
    public InlineArrayUInt321 aPolyCounts;
    public InlineArrayPOINTL1 aptl; // variable-length array placeholder
}
