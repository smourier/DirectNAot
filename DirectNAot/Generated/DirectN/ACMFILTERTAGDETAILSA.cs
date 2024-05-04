#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct ACMFILTERTAGDETAILSA
{
    public uint cbStruct;
    public uint dwFilterTagIndex;
    public uint dwFilterTag;
    public uint cbFilterSize;
    public uint fdwSupport;
    public uint cStandardFilters;
    public InlineArrayFoundationCHAR48 szFilterTag;
}
