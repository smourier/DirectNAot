#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KS_COMPRESSION
{
    public uint RatioNumerator;
    public uint RatioDenominator;
    public uint RatioConstantMargin;
}
