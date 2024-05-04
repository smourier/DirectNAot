#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DvbParentalRatingDescriptor
{
    public uint ulNumParams;
    public InlineArrayDvbParentalRatingParam1 pParams; // variable-length array placeholder
}
