#nullable enable
namespace DirectN;

public partial struct KSCAMERA_METADATA_BACKGROUNDSEGMENTATIONMASK
{
    public KSCAMERA_METADATA_ITEMHEADER Header;
    public RECT MaskCoverageBoundingBox;
    public SIZE MaskResolution;
    public RECT ForegroundBoundingBox;
    public InlineArrayByte_1 MaskData; // variable-length array placeholder
}
