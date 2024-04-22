namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct VIDEO_LUT_RGB256WORDS
{
    public InlineArrayUInt16256 Red;
    public InlineArrayUInt16256 Green;
    public InlineArrayUInt16256 Blue;
}
