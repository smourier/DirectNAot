#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddraw/ns-ddraw-ddpixelformat
[StructLayout(LayoutKind.Sequential)]
public partial struct DDPIXELFORMAT
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous1_e__Union
    {
        [FieldOffset(0)]
        public uint dwRGBBitCount;
        
        [FieldOffset(0)]
        public uint dwYUVBitCount;
        
        [FieldOffset(0)]
        public uint dwZBufferBitDepth;
        
        [FieldOffset(0)]
        public uint dwAlphaBitDepth;
        
        [FieldOffset(0)]
        public uint dwLuminanceBitCount;
        
        [FieldOffset(0)]
        public uint dwBumpBitCount;
        
        [FieldOffset(0)]
        public uint dwPrivateFormatBitCount;
    }
    
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous2_e__Union
    {
        [FieldOffset(0)]
        public uint dwRBitMask;
        
        [FieldOffset(0)]
        public uint dwYBitMask;
        
        [FieldOffset(0)]
        public uint dwStencilBitDepth;
        
        [FieldOffset(0)]
        public uint dwLuminanceBitMask;
        
        [FieldOffset(0)]
        public uint dwBumpDuBitMask;
        
        [FieldOffset(0)]
        public uint dwOperations;
    }
    
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous3_e__Union
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct _MultiSampleCaps_e__Struct
        {
            public ushort wFlipMSTypes;
            public ushort wBltMSTypes;
        }
        
        [FieldOffset(0)]
        public uint dwGBitMask;
        
        [FieldOffset(0)]
        public uint dwUBitMask;
        
        [FieldOffset(0)]
        public uint dwZBitMask;
        
        [FieldOffset(0)]
        public uint dwBumpDvBitMask;
        
        [FieldOffset(0)]
        public _MultiSampleCaps_e__Struct MultiSampleCaps;
    }
    
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous4_e__Union
    {
        [FieldOffset(0)]
        public uint dwBBitMask;
        
        [FieldOffset(0)]
        public uint dwVBitMask;
        
        [FieldOffset(0)]
        public uint dwStencilBitMask;
        
        [FieldOffset(0)]
        public uint dwBumpLuminanceBitMask;
    }
    
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous5_e__Union
    {
        [FieldOffset(0)]
        public uint dwRGBAlphaBitMask;
        
        [FieldOffset(0)]
        public uint dwYUVAlphaBitMask;
        
        [FieldOffset(0)]
        public uint dwLuminanceAlphaBitMask;
        
        [FieldOffset(0)]
        public uint dwRGBZBitMask;
        
        [FieldOffset(0)]
        public uint dwYUVZBitMask;
    }
    
    public uint dwSize;
    public uint dwFlags;
    public uint dwFourCC;
    public _Anonymous1_e__Union Anonymous1;
    public _Anonymous2_e__Union Anonymous2;
    public _Anonymous3_e__Union Anonymous3;
    public _Anonymous4_e__Union Anonymous4;
    public _Anonymous5_e__Union Anonymous5;
}
