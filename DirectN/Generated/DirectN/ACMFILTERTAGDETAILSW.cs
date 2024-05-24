#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct ACMFILTERTAGDETAILSW
{
    public uint cbStruct;
    public uint dwFilterTagIndex;
    public uint dwFilterTag;
    public uint cbFilterSize;
    public uint fdwSupport;
    public uint cStandardFilters;
    public InlineArraySystemChar_48 szFilterTag;
}
