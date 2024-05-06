#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct AVITIMECODEINDEX
{
    public uint fcc;
    public uint cb;
    public ushort wLongsPerEntry;
    public byte bIndexSubType;
    public byte bIndexType;
    public uint nEntriesInUse;
    public uint dwChunkId;
    public InlineArrayUInt32_3 dwReserved;
    public InlineArrayTIMECODEDATA_1022 aIndex;
}
