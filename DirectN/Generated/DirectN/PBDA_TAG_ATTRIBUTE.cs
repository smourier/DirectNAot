#nullable enable
namespace DirectN;

public partial struct PBDA_TAG_ATTRIBUTE
{
    public Guid TableUUId;
    public byte TableId;
    public ushort VersionNo;
    public uint TableDataSize;
    public InlineArrayByte_1 TableData; // variable-length array placeholder
}
