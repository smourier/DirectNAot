namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSCAMERA_METADATA_BACKGROUNDSEGMENTATIONMASK
{
    public KSCAMERA_METADATA_ITEMHEADER Header;
    public FoundationRECT MaskCoverageBoundingBox;
    public FoundationSIZE MaskResolution;
    public FoundationRECT ForegroundBoundingBox;
    public InlineArrayByte1 MaskData; // variable-length array placeholder
}
