#nullable enable
namespace DirectN;

public partial struct VIDMEM
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous1_e__Union
    {
        [FieldOffset(0)]
        public nuint fpEnd;
        
        [FieldOffset(0)]
        public uint dwWidth;
    }
    
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous2_e__Union
    {
        [FieldOffset(0)]
        public nint lpHeap;
        
        [FieldOffset(0)]
        public uint dwHeight;
    }
    
    public uint dwFlags;
    public nuint fpStart;
    public _Anonymous1_e__Union Anonymous1;
    public DDSCAPS ddsCaps;
    public DDSCAPS ddsCapsAlt;
    public _Anonymous2_e__Union Anonymous2;
}
