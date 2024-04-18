namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddraw/ns-ddraw-ddbltfx
[StructLayout(LayoutKind.Sequential)]
public partial struct DDBLTFX
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous1_e__Union
    {
        [FieldOffset(0)]
        public uint dwZDestConst;
        
        [FieldOffset(0)]
        public nint lpDDSZBufferDest;
    }
    
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous2_e__Union
    {
        [FieldOffset(0)]
        public uint dwZSrcConst;
        
        [FieldOffset(0)]
        public nint lpDDSZBufferSrc;
    }
    
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous3_e__Union
    {
        [FieldOffset(0)]
        public uint dwAlphaDestConst;
        
        [FieldOffset(0)]
        public nint lpDDSAlphaDest;
    }
    
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous4_e__Union
    {
        [FieldOffset(0)]
        public uint dwAlphaSrcConst;
        
        [FieldOffset(0)]
        public nint lpDDSAlphaSrc;
    }
    
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous5_e__Union
    {
        [FieldOffset(0)]
        public uint dwFillColor;
        
        [FieldOffset(0)]
        public uint dwFillDepth;
        
        [FieldOffset(0)]
        public uint dwFillPixel;
        
        [FieldOffset(0)]
        public nint lpDDSPattern;
    }
    
    public uint dwSize;
    public uint dwDDFX;
    public uint dwROP;
    public uint dwDDROP;
    public uint dwRotationAngle;
    public uint dwZBufferOpCode;
    public uint dwZBufferLow;
    public uint dwZBufferHigh;
    public uint dwZBufferBaseDest;
    public uint dwZDestConstBitDepth;
    public _Anonymous1_e__Union Anonymous1;
    public uint dwZSrcConstBitDepth;
    public _Anonymous2_e__Union Anonymous2;
    public uint dwAlphaEdgeBlendBitDepth;
    public uint dwAlphaEdgeBlend;
    public uint dwReserved;
    public uint dwAlphaDestConstBitDepth;
    public _Anonymous3_e__Union Anonymous3;
    public uint dwAlphaSrcConstBitDepth;
    public _Anonymous4_e__Union Anonymous4;
    public _Anonymous5_e__Union Anonymous5;
    public DDCOLORKEY ddckDestColorkey;
    public DDCOLORKEY ddckSrcColorkey;
}
