namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct BRIGHTNESS_NIT_RANGES
{
    public uint NormalRangeCount;
    public uint RangeCount;
    public uint PreferredMaximumBrightness;
    public InlineArrayBRIGHTNESS_NIT_RANGE16 SupportedRanges;
}
