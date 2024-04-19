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
    public InlineArrayUInt323 dwReserved;
    public InlineArrayTIMECODEDATA1022 aIndex;
}
