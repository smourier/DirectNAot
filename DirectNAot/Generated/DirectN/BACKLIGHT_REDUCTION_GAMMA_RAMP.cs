namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct BACKLIGHT_REDUCTION_GAMMA_RAMP
{
    public InlineArrayUInt16256 R;
    public InlineArrayUInt16256 G;
    public InlineArrayUInt16256 B;
}
