#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential, Pack = 2)]
public partial struct AVIFIELDINDEX
{
    [InlineArray(InlineArray_avifieldindex_entry_1.Length)]
    public partial struct InlineArray_avifieldindex_entry_1
    {
        public const int Length = 1;
        
        public _avifieldindex_entry Data;
    }
    
    [StructLayout(LayoutKind.Sequential, Pack = 2)]
    public struct _avifieldindex_entry
    {
        public uint dwOffset;
        public uint dwSize;
        public uint dwOffsetField2;
    }
    
    public uint fcc;
    public uint cb;
    public ushort wLongsPerEntry;
    public byte bIndexSubType;
    public byte bIndexType;
    public uint nEntriesInUse;
    public uint dwChunkId;
    public ulong qwBaseOffset;
    public uint dwReserved3;
    public InlineArray_avifieldindex_entry_1 aIndex;
}
