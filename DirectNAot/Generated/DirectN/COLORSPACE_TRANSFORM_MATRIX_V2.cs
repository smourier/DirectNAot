#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct COLORSPACE_TRANSFORM_MATRIX_V2
{
    public COLORSPACE_TRANSFORM_STAGE_CONTROL StageControlLookupTable1DDegamma;
    public InlineArrayGAMMA_RAMP_RGB_4096 LookupTable1DDegamma;
    public COLORSPACE_TRANSFORM_STAGE_CONTROL StageControlColorMatrix3x3;
    public InlineArraySingle_9 ColorMatrix3x3;
    public COLORSPACE_TRANSFORM_STAGE_CONTROL StageControlLookupTable1DRegamma;
    public InlineArrayGAMMA_RAMP_RGB_4096 LookupTable1DRegamma;
}
