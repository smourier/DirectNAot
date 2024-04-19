namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/aviriff/ns-aviriff-avisuperindex
[StructLayout(LayoutKind.Sequential)]
public partial struct AVISUPERINDEX
{
    [InlineArray(1022)]
    public partial struct InlineArray_avisuperindex_entry1022
    {
        public _avisuperindex_entry Data;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct _avisuperindex_entry
    {
        public ulong qwOffset;
        public uint dwSize;
        public uint dwDuration;
    }
    
    public uint fcc;
    public uint cb;
    public ushort wLongsPerEntry;
    public byte bIndexSubType;
    public byte bIndexType;
    public uint nEntriesInUse;
    public uint dwChunkId;
    public InlineArrayUInt323 dwReserved;
    public InlineArray_avisuperindex_entry1022 aIndex;
}
