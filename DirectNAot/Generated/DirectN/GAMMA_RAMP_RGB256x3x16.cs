#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct GAMMA_RAMP_RGB256x3x16
{
    public InlineArrayUInt16_256 Red;
    public InlineArrayUInt16_256 Green;
    public InlineArrayUInt16_256 Blue;
}
