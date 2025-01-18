#nullable enable
namespace DirectN;

// https://learn.microsoft.com/previous-versions/windows/desktop/api/aviriff/ns-aviriff-avisuperindex
[StructLayout(LayoutKind.Sequential, Pack = 2)]
public partial struct AVISUPERINDEX
{
    [InlineArray(InlineArray_avisuperindex_entry_1022.Length)]
    public partial struct InlineArray_avisuperindex_entry_1022
    {
        public const int Length = 1022;
        
        public _avisuperindex_entry Data;
    }
    
    [StructLayout(LayoutKind.Sequential, Pack = 2)]
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
    public InlineArrayUInt32_3 dwReserved;
    public InlineArray_avisuperindex_entry_1022 aIndex;
}
