#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct AVITCDLINDEX
{
    public uint fcc;
    public uint cb;
    public ushort wLongsPerEntry;
    public byte bIndexSubType;
    public byte bIndexType;
    public uint nEntriesInUse;
    public uint dwChunkId;
    public InlineArrayUInt32_3 dwReserved;
    public InlineArrayAVITCDLINDEX_ENTRY_584 aIndex;
    public InlineArrayUInt32_3512 adwTrailingFill;
}
