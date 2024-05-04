#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct BDA_TABLE_SECTION
{
    public uint ulPrimarySectionId;
    public uint ulSecondarySectionId;
    public uint ulcbSectionLength;
    public InlineArrayUInt321 argbSectionData; // variable-length array placeholder
}
