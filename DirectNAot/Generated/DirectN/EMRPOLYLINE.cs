namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-emrpolyline
[StructLayout(LayoutKind.Sequential)]
public partial struct EMRPOLYLINE
{
    public EMR emr;
    public RECTL rclBounds;
    public uint cptl;
    public InlineArrayPOINTL1 aptl; // variable-length array placeholder
}
