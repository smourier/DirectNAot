#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSALLOCATOR_FRAMING_EX
{
    public uint CountItems;
    public uint PinFlags;
    public KS_COMPRESSION OutputCompression;
    public uint PinWeight;
    public InlineArrayKS_FRAMING_ITEM1 FramingItem; // variable-length array placeholder
}
