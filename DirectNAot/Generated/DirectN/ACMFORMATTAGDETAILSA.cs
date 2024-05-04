#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct ACMFORMATTAGDETAILSA
{
    public uint cbStruct;
    public uint dwFormatTagIndex;
    public uint dwFormatTag;
    public uint cbFormatSize;
    public uint fdwSupport;
    public uint cStandardFormats;
    public InlineArrayFoundationCHAR48 szFormatTag;
}
