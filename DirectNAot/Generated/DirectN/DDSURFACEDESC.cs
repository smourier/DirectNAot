#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddraw/ns-ddraw-ddsurfacedesc
[StructLayout(LayoutKind.Sequential)]
public partial struct DDSURFACEDESC
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous1_e__Union
    {
        [FieldOffset(0)]
        public int lPitch;
        
        [FieldOffset(0)]
        public uint dwLinearSize;
    }
    
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous2_e__Union
    {
        [FieldOffset(0)]
        public uint dwMipMapCount;
        
        [FieldOffset(0)]
        public uint dwZBufferBitDepth;
        
        [FieldOffset(0)]
        public uint dwRefreshRate;
    }
    
    public uint dwSize;
    public uint dwFlags;
    public uint dwHeight;
    public uint dwWidth;
    public _Anonymous1_e__Union Anonymous1;
    public uint dwBackBufferCount;
    public _Anonymous2_e__Union Anonymous2;
    public uint dwAlphaBitDepth;
    public uint dwReserved;
    public nint lpSurface;
    public DDCOLORKEY ddckCKDestOverlay;
    public DDCOLORKEY ddckCKDestBlt;
    public DDCOLORKEY ddckCKSrcOverlay;
    public DDCOLORKEY ddckCKSrcBlt;
    public DDPIXELFORMAT ddpfPixelFormat;
    public DDSCAPS ddsCaps;
}
