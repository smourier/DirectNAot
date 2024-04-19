namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DvbParentalRatingParam
{
    public InlineArrayCHAR4 szCountryCode;
    public byte bRating;
}
