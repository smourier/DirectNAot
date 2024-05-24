#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/aviriff/ns-aviriff-avioldindex
[StructLayout(LayoutKind.Sequential, Pack = 2)]
public partial struct AVIOLDINDEX
{
    [InlineArray(InlineArray_avioldindex_entry_1.Length)]
    public partial struct InlineArray_avioldindex_entry_1
    {
        public const int Length = 1;
        
        public _avioldindex_entry Data;
    }
    
    [StructLayout(LayoutKind.Sequential, Pack = 2)]
    public struct _avioldindex_entry
    {
        public uint dwChunkId;
        public uint dwFlags;
        public uint dwOffset;
        public uint dwSize;
    }
    
    public uint fcc;
    public uint cb;
    public InlineArray_avioldindex_entry_1 aIndex;
}
