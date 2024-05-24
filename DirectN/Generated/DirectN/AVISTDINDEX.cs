#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/aviriff/ns-aviriff-avistdindex
[StructLayout(LayoutKind.Sequential, Pack = 2)]
public partial struct AVISTDINDEX
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
    public InlineArrayAVISTDINDEX_ENTRY_2044 aIndex;
}
