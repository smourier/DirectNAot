#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct Mpeg2TableSampleHdr
{
    public byte SectionCount;
    public InlineArrayByte_3 Reserved;
    public InlineArrayInt32_1 SectionOffsets; // variable-length array placeholder
}
