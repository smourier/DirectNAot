#nullable enable
namespace DirectN;

public partial struct KSALLOCATOR_FRAMING_EX
{
    public uint CountItems;
    public uint PinFlags;
    public KS_COMPRESSION OutputCompression;
    public uint PinWeight;
    public InlineArrayKS_FRAMING_ITEM_1 FramingItem; // variable-length array placeholder
}
