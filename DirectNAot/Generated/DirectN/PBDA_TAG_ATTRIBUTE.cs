#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct PBDA_TAG_ATTRIBUTE
{
    public Guid TableUUId;
    public byte TableId;
    public ushort VersionNo;
    public uint TableDataSize;
    public InlineArrayByte1 TableData; // variable-length array placeholder
}
