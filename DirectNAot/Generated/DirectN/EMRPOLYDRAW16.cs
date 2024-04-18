namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-emrpolydraw16
[StructLayout(LayoutKind.Sequential)]
public partial struct EMRPOLYDRAW16
{
    public EMR emr;
    public RECTL rclBounds;
    public uint cpts;
    public InlineArrayPOINTS1 apts;
    public InlineArrayByte1 abTypes; // variable-length array placeholder
}
