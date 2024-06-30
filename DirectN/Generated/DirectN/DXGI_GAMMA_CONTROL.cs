#nullable enable
namespace DirectN;

public partial struct DXGI_GAMMA_CONTROL
{
    public DXGI_RGB Scale;
    public DXGI_RGB Offset;
    public InlineArrayDXGI_RGB_1025 GammaCurve;
}
