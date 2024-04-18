namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-emrframergn
[StructLayout(LayoutKind.Sequential)]
public partial struct EMRFRAMERGN
{
    public EMR emr;
    public RECTL rclBounds;
    public uint cbRgnData;
    public uint ihBrush;
    public nint szlStroke;
    public InlineArrayByte1 RgnData; // variable-length array placeholder
}
