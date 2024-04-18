namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawint/ns-ddrawint-dd_surface_local
[StructLayout(LayoutKind.Sequential)]
public partial struct DD_SURFACE_LOCAL
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous1_e__Union
    {
        [FieldOffset(0)]
        public DDCOLORKEY ddckCKSrcOverlay;
        
        [FieldOffset(0)]
        public DDCOLORKEY ddckCKSrcBlt;
    }
    
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous2_e__Union
    {
        [FieldOffset(0)]
        public DDCOLORKEY ddckCKDestOverlay;
        
        [FieldOffset(0)]
        public DDCOLORKEY ddckCKDestBlt;
    }
    
    public nint lpGbl;
    public uint dwFlags;
    public DDSCAPS ddsCaps;
    public nuint dwReserved1;
    public _Anonymous1_e__Union Anonymous1;
    public _Anonymous2_e__Union Anonymous2;
    public nint lpSurfMore;
    public nint lpAttachList;
    public nint lpAttachListFrom;
    public FoundationRECT rcOverlaySrc;
}
