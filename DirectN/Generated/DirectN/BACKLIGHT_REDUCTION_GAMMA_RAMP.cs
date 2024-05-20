#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct BACKLIGHT_REDUCTION_GAMMA_RAMP
{
    public InlineArrayUInt16_256 R;
    public InlineArrayUInt16_256 G;
    public InlineArrayUInt16_256 B;
}
