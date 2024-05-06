#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DvbParentalRatingParam
{
    public InlineArrayCHAR_4 szCountryCode;
    public byte bRating;
}
