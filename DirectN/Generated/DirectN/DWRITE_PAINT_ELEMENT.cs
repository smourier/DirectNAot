#nullable enable
namespace DirectN;

public partial struct DWRITE_PAINT_ELEMENT
{
    [StructLayout(LayoutKind.Explicit)]
    public struct PAINT_UNION
    {
        public struct PAINT_LAYERS
        {
            public uint childCount;
        }
        
        public struct PAINT_SOLID_GLYPH
        {
            public uint glyphIndex;
            public DWRITE_PAINT_COLOR color;
        }
        
        public struct PAINT_LINEAR_GRADIENT
        {
            public uint extendMode;
            public uint gradientStopCount;
            public float x0;
            public float y0;
            public float x1;
            public float y1;
            public float x2;
            public float y2;
        }
        
        public struct PAINT_RADIAL_GRADIENT
        {
            public uint extendMode;
            public uint gradientStopCount;
            public float x0;
            public float y0;
            public float radius0;
            public float x1;
            public float y1;
            public float radius1;
        }
        
        public struct PAINT_SWEEP_GRADIENT
        {
            public uint extendMode;
            public uint gradientStopCount;
            public float centerX;
            public float centerY;
            public float startAngle;
            public float endAngle;
        }
        
        public struct PAINT_GLYPH
        {
            public uint glyphIndex;
        }
        
        public struct PAINT_COLOR_GLYPH
        {
            public uint glyphIndex;
            public D2D_RECT_F clipBox;
        }
        
        public struct PAINT_COMPOSITE
        {
            public DWRITE_COLOR_COMPOSITE_MODE mode;
        }
        
        [FieldOffset(0)]
        public PAINT_LAYERS layers;
        
        [FieldOffset(0)]
        public PAINT_SOLID_GLYPH solidGlyph;
        
        [FieldOffset(0)]
        public DWRITE_PAINT_COLOR solid;
        
        [FieldOffset(0)]
        public PAINT_LINEAR_GRADIENT linearGradient;
        
        [FieldOffset(0)]
        public PAINT_RADIAL_GRADIENT radialGradient;
        
        [FieldOffset(0)]
        public PAINT_SWEEP_GRADIENT sweepGradient;
        
        [FieldOffset(0)]
        public PAINT_GLYPH glyph;
        
        [FieldOffset(0)]
        public PAINT_COLOR_GLYPH colorGlyph;
        
        [FieldOffset(0)]
        public DWRITE_MATRIX transform;
        
        [FieldOffset(0)]
        public PAINT_COMPOSITE composite;
    }
    
    public DWRITE_PAINT_TYPE paintType;
    public PAINT_UNION paint;
}
