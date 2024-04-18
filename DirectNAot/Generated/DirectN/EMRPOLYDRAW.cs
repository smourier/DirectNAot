namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-emrpolydraw
[StructLayout(LayoutKind.Sequential)]
public partial struct EMRPOLYDRAW
{
    public EMR emr;
    public RECTL rclBounds;
    public uint cptl;
    public InlineArrayPOINTL1 aptl;
    public InlineArrayByte1 abTypes; // variable-length array placeholder
}
