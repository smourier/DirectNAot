namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/aviriff/ns-aviriff-avioldindex
[StructLayout(LayoutKind.Sequential)]
public partial struct AVIOLDINDEX
{
    [InlineArray(1)]
    public partial struct InlineArray_avioldindex_entry1
    {
        public _avioldindex_entry Data;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct _avioldindex_entry
    {
        public uint dwChunkId;
        public uint dwFlags;
        public uint dwOffset;
        public uint dwSize;
    }
    
    public uint fcc;
    public uint cb;
    public InlineArray_avioldindex_entry1 aIndex;
}
