namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-emrgradientfill
[StructLayout(LayoutKind.Sequential)]
public partial struct EMRGRADIENTFILL
{
    public EMR emr;
    public RECTL rclBounds;
    public uint nVer;
    public uint nTri;
    public GRADIENT_FILL ulMode;
    public InlineArrayTRIVERTEX1 Ver; // variable-length array placeholder
}
