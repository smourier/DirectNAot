#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct ACMFORMATTAGDETAILSA
{
    public uint cbStruct;
    public uint dwFormatTagIndex;
    public uint dwFormatTag;
    public uint cbFormatSize;
    public uint fdwSupport;
    public uint cStandardFormats;
    public InlineArrayFoundationCHAR_48 szFormatTag;
}
