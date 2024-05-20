#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KS_TRUECOLORINFO
{
    public InlineArrayUInt32_3 dwBitMasks;
    public InlineArrayKS_RGBQUAD_256 bmiColors;
}
