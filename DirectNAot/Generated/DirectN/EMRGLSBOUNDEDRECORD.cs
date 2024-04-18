namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-emrglsboundedrecord
[StructLayout(LayoutKind.Sequential)]
public partial struct EMRGLSBOUNDEDRECORD
{
    public EMR emr;
    public RECTL rclBounds;
    public uint cbData;
    public InlineArrayByte1 Data; // variable-length array placeholder
}
