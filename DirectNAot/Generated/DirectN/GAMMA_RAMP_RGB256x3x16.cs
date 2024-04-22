namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct GAMMA_RAMP_RGB256x3x16
{
    public InlineArrayUInt16256 Red;
    public InlineArrayUInt16256 Green;
    public InlineArrayUInt16256 Blue;
}
