namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KS_TRUECOLORINFO
{
    public InlineArrayUInt323 dwBitMasks;
    public InlineArrayKS_RGBQUAD256 bmiColors;
}
