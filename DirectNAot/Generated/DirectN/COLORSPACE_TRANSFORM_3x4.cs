#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct COLORSPACE_TRANSFORM_3x4
{
    public InlineArraySingle12 ColorMatrix3x4;
    public float ScalarMultiplier;
    public InlineArrayGAMMA_RAMP_RGB4096 LookupTable1D;
}
