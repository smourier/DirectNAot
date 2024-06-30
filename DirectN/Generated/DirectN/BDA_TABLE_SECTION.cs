#nullable enable
namespace DirectN;

public partial struct BDA_TABLE_SECTION
{
    public uint ulPrimarySectionId;
    public uint ulSecondarySectionId;
    public uint ulcbSectionLength;
    public InlineArrayUInt32_1 argbSectionData; // variable-length array placeholder
}
