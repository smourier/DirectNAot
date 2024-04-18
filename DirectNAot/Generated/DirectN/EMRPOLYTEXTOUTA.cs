namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-emrpolytextouta
[StructLayout(LayoutKind.Sequential)]
public partial struct EMRPOLYTEXTOUTA
{
    public EMR emr;
    public RECTL rclBounds;
    public uint iGraphicsMode;
    public float exScale;
    public float eyScale;
    public int cStrings;
    public InlineArrayEMRTEXT1 aemrtext; // variable-length array placeholder
}
