namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-emrfillrgn
[StructLayout(LayoutKind.Sequential)]
public partial struct EMRFILLRGN
{
    public EMR emr;
    public RECTL rclBounds;
    public uint cbRgnData;
    public uint ihBrush;
    public InlineArrayByte1 RgnData; // variable-length array placeholder
}
