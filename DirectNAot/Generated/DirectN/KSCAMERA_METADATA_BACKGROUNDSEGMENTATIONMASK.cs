namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSCAMERA_METADATA_BACKGROUNDSEGMENTATIONMASK
{
    public KSCAMERA_METADATA_ITEMHEADER Header;
    public RECT MaskCoverageBoundingBox;
    public SIZE MaskResolution;
    public RECT ForegroundBoundingBox;
    public InlineArrayByte1 MaskData; // variable-length array placeholder
}
