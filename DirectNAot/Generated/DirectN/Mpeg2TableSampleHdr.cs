namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct Mpeg2TableSampleHdr
{
    public byte SectionCount;
    public InlineArrayByte3 Reserved;
    public InlineArrayInt321 SectionOffsets; // variable-length array placeholder
}
