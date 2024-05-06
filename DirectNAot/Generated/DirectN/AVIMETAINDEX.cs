#nullable enable
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
    public InlineArrayUInt32_3 dwReserved;
    public InlineArrayUInt32_1 adwIndex;
}
