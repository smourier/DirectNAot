#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct Mpeg2TableSampleHdr
{
    public byte SectionCount;
    public InlineArrayByte_3 Reserved;
    public InlineArrayInt32_1 SectionOffsets; // variable-length array placeholder
}
