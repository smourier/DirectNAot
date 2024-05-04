#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct AVIFIELDINDEX
{
    [InlineArray(1)]
    public partial struct InlineArray_avifieldindex_entry1
    {
        public _avifieldindex_entry Data;
    }
    
    [StructLayout(LayoutKind.Sequential)]
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
    public InlineArray_avifieldindex_entry1 aIndex;
}
