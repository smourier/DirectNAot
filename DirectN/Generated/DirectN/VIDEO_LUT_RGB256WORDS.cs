#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct VIDEO_LUT_RGB256WORDS
{
    public InlineArrayUInt16_256 Red;
    public InlineArrayUInt16_256 Green;
    public InlineArrayUInt16_256 Blue;
}
