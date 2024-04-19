namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/aviriff/ns-aviriff-avimetaindex
[StructLayout(LayoutKind.Sequential)]
public partial struct AVIMETAINDEX
{
    public uint fcc;
    public uint cb;
    public ushort wLongsPerEntry;
    public byte bIndexSubType;
    public byte bIndexType;
    public uint nEntriesInUse;
    public uint dwChunkId;
    public InlineArrayUInt323 dwReserved;
    public InlineArrayUInt321 adwIndex;
}
