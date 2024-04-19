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
    public InlineArrayUInt323 dwReserved;
    public InlineArrayAVITCDLINDEX_ENTRY584 aIndex;
    public InlineArrayUInt323512 adwTrailingFill;
}
