#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddraw/ns-ddraw-ddsurfacedesc2
public partial struct DDSURFACEDESC2
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
        public uint dwBackBufferCount;
        
        [FieldOffset(0)]
        public uint dwDepth;
    }
    
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous3_e__Union
    {
        [FieldOffset(0)]
        public uint dwMipMapCount;
        
        [FieldOffset(0)]
        public uint dwRefreshRate;
        
        [FieldOffset(0)]
        public uint dwSrcVBHandle;
    }
    
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous4_e__Union
    {
        [FieldOffset(0)]
        public DDCOLORKEY ddckCKDestOverlay;
        
        [FieldOffset(0)]
        public uint dwEmptyFaceColor;
    }
    
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous5_e__Union
    {
        [FieldOffset(0)]
        public DDPIXELFORMAT ddpfPixelFormat;
        
        [FieldOffset(0)]
        public uint dwFVF;
    }
    
    public uint dwSize;
    public uint dwFlags;
    public uint dwHeight;
    public uint dwWidth;
    public _Anonymous1_e__Union Anonymous1;
    public _Anonymous2_e__Union Anonymous2;
    public _Anonymous3_e__Union Anonymous3;
    public uint dwAlphaBitDepth;
    public uint dwReserved;
    public nint lpSurface;
    public _Anonymous4_e__Union Anonymous4;
    public DDCOLORKEY ddckCKDestBlt;
    public DDCOLORKEY ddckCKSrcOverlay;
    public DDCOLORKEY ddckCKSrcBlt;
    public _Anonymous5_e__Union Anonymous5;
    public DDSCAPS2 ddsCaps;
    public uint dwTextureStage;
}
