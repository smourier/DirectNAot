namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KS_FRAME_INFO
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous1_e__Union
    {
        [FieldOffset(0)]
        public int lSurfacePitch;
        
        [FieldOffset(0)]
        public uint Reserved1;
    }
    
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous2_e__Union
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct _Anonymous_e__Struct
        {
            public uint Reserved3;
            public uint Reserved4;
        }
        
        [FieldOffset(0)]
        public _Anonymous_e__Struct Anonymous;
        
        [FieldOffset(0)]
        public ulong FrameCompletionNumber;
    }
    
    public uint ExtendedHeaderSize;
    public uint dwFrameFlags;
    public long PictureNumber;
    public long DropCount;
    public HANDLE hDirectDraw;
    public HANDLE hSurfaceHandle;
    public FoundationRECT DirectDrawRect;
    public _Anonymous1_e__Union Anonymous1;
    public uint Reserved2;
    public _Anonymous2_e__Union Anonymous2;
}
