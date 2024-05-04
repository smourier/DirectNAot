#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct ColorCurveParams
{
    public CurveAdjustments adjustment;
    public CurveChannel channel;
    public int adjustValue;
}
