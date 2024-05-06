#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct ACMFORMATTAGDETAILSW
{
    public uint cbStruct;
    public uint dwFormatTagIndex;
    public uint dwFormatTag;
    public uint cbFormatSize;
    public uint fdwSupport;
    public uint cStandardFormats;
    public InlineArraySystemChar_48 szFormatTag;
}
