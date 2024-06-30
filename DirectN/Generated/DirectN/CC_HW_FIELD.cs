#nullable enable
namespace DirectN;

public partial struct CC_HW_FIELD
{
    public VBICODECFILTERING_SCANLINES ScanlinesRequested;
    public uint fieldFlags;
    public long PictureNumber;
    public InlineArrayCC_BYTE_PAIR_12 Lines;
}
