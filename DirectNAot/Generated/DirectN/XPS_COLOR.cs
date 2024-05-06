#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/ns-xpsobjectmodel-xps_color
[StructLayout(LayoutKind.Sequential)]
public partial struct XPS_COLOR
{
    [StructLayout(LayoutKind.Explicit)]
    public struct XPS_COLOR_VALUE
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct _sRGB_e__Struct
        {
            public byte alpha;
            public byte red;
            public byte green;
            public byte blue;
        }
        
        [StructLayout(LayoutKind.Sequential)]
        public struct _scRGB_e__Struct
        {
            public float alpha;
            public float red;
            public float green;
            public float blue;
        }
        
        [StructLayout(LayoutKind.Sequential)]
        public struct _context_e__Struct
        {
            public byte channelCount;
            public InlineArraySingle_9 channels;
        }
        
        [FieldOffset(0)]
        public _sRGB_e__Struct sRGB;
        
        [FieldOffset(0)]
        public _scRGB_e__Struct scRGB;
        
        [FieldOffset(0)]
        public _context_e__Struct context;
    }
    
    public XPS_COLOR_TYPE colorType;
    public XPS_COLOR_VALUE value;
}
