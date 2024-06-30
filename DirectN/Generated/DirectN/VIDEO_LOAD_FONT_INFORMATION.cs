#nullable enable
namespace DirectN;

public partial struct VIDEO_LOAD_FONT_INFORMATION
{
    public ushort WidthInPixels;
    public ushort HeightInPixels;
    public uint FontSize;
    public InlineArrayByte_1 Font; // variable-length array placeholder
}
