namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-emrinvertrgn
[StructLayout(LayoutKind.Sequential)]
public partial struct EMRINVERTRGN
{
    public EMR emr;
    public RECTL rclBounds;
    public uint cbRgnData;
    public InlineArrayByte1 RgnData; // variable-length array placeholder
}
