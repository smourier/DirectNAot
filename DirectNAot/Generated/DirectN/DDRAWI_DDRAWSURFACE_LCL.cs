namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DDRAWI_DDRAWSURFACE_LCL
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous1_e__Union
    {
        [FieldOffset(0)]
        public nint lpDDPalette;
        
        [FieldOffset(0)]
        public nint lp16DDPalette;
    }
    
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous2_e__Union
    {
        [FieldOffset(0)]
        public nint lpDDClipper;
        
        [FieldOffset(0)]
        public nint lp16DDClipper;
    }
    
    public nint lpSurfMore;
    public nint lpGbl;
    public nuint hDDSurface;
    public nint lpAttachList;
    public nint lpAttachListFrom;
    public uint dwLocalRefCnt;
    public uint dwProcessId;
    public uint dwFlags;
    public DDSCAPS ddsCaps;
    public _Anonymous1_e__Union Anonymous1;
    public _Anonymous2_e__Union Anonymous2;
    public uint dwModeCreatedIn;
    public uint dwBackBufferCount;
    public DDCOLORKEY ddckCKDestBlt;
    public DDCOLORKEY ddckCKSrcBlt;
    public nuint hDC;
    public nuint dwReserved1;
    public DDCOLORKEY ddckCKSrcOverlay;
    public DDCOLORKEY ddckCKDestOverlay;
    public nint lpSurfaceOverlaying;
    public DBLNODE dbnOverlayNode;
    public RECT rcOverlaySrc;
    public RECT rcOverlayDest;
    public uint dwClrXparent;
    public uint dwAlpha;
    public int lOverlayX;
    public int lOverlayY;
}
