#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct GAMMA_RAMP_DXGI_1
{
    public GAMMA_RAMP_RGB Scale;
    public GAMMA_RAMP_RGB Offset;
    public InlineArrayGAMMA_RAMP_RGB_1025 GammaCurve;
}
