#nullable enable
namespace DirectN;

public partial struct COR_GC_STATS
{
    public uint Flags;
    public nuint ExplicitGCCount;
    public InlineArrayUIntPtr_3 GenCollectionsTaken;
    public nuint CommittedKBytes;
    public nuint ReservedKBytes;
    public nuint Gen0HeapSizeKBytes;
    public nuint Gen1HeapSizeKBytes;
    public nuint Gen2HeapSizeKBytes;
    public nuint LargeObjectHeapSizeKBytes;
    public nuint KBytesPromotedFromGen0;
    public nuint KBytesPromotedFromGen1;
}
