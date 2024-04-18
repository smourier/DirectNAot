namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DDRAWI_DDRAWSURFACE_GBL
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous1_e__Union
    {
        [FieldOffset(0)]
        public nint lpRectList;
        
        [FieldOffset(0)]
        public uint dwBlockSizeY;
        
        [FieldOffset(0)]
        public int lSlicePitch;
    }
    
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous2_e__Union
    {
        [FieldOffset(0)]
        public nint lpVidMemHeap;
        
        [FieldOffset(0)]
        public uint dwBlockSizeX;
    }
    
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous3_e__Union
    {
        [FieldOffset(0)]
        public nint lpDD;
        
        [FieldOffset(0)]
        public nint lpDDHandle;
    }
    
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous4_e__Union
    {
        [FieldOffset(0)]
        public int lPitch;
        
        [FieldOffset(0)]
        public uint dwLinearSize;
    }
    
    public uint dwRefCnt;
    public uint dwGlobalFlags;
    public _Anonymous1_e__Union Anonymous1;
    public _Anonymous2_e__Union Anonymous2;
    public _Anonymous3_e__Union Anonymous3;
    public nuint fpVidMem;
    public _Anonymous4_e__Union Anonymous4;
    public ushort wHeight;
    public ushort wWidth;
    public uint dwUsageCount;
    public nuint dwReserved1;
    public DDPIXELFORMAT ddpfSurface;
}
