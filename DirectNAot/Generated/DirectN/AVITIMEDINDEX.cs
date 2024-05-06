#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct AVITIMEDINDEX
{
    public uint fcc;
    public uint cb;
    public ushort wLongsPerEntry;
    public byte bIndexSubType;
    public byte bIndexType;
    public uint nEntriesInUse;
    public uint dwChunkId;
    public ulong qwBaseOffset;
    public uint dwReserved_3;
    public InlineArrayAVITIMEDINDEX_ENTRY_1362 aIndex;
    public InlineArrayUInt32_2734 adwTrailingFill;
}
