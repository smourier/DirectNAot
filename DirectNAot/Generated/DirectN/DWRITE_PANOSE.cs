#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite_1/ns-dwrite_1-dwrite_panose
[StructLayout(LayoutKind.Explicit)]
public partial struct DWRITE_PANOSE
{
    [StructLayout(LayoutKind.Sequential)]
    public struct _decorative_e__Struct
    {
        public byte familyKind;
        public byte decorativeClass;
        public byte weight;
        public byte aspect;
        public byte contrast;
        public byte serifVariant;
        public byte fill;
        public byte lining;
        public byte decorativeTopology;
        public byte characterRange;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct _script_e__Struct
    {
        public byte familyKind;
        public byte toolKind;
        public byte weight;
        public byte spacing;
        public byte aspectRatio;
        public byte contrast;
        public byte scriptTopology;
        public byte scriptForm;
        public byte finials;
        public byte xAscent;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct _symbol_e__Struct
    {
        public byte familyKind;
        public byte symbolKind;
        public byte weight;
        public byte spacing;
        public byte aspectRatioAndContrast;
        public byte aspectRatio94;
        public byte aspectRatio119;
        public byte aspectRatio157;
        public byte aspectRatio163;
        public byte aspectRatio211;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct _text_e__Struct
    {
        public byte familyKind;
        public byte serifStyle;
        public byte weight;
        public byte proportion;
        public byte contrast;
        public byte strokeVariation;
        public byte armStyle;
        public byte letterform;
        public byte midline;
        public byte xHeight;
    }
    
    [FieldOffset(0)]
    public InlineArrayByte_10 values;
    
    [FieldOffset(0)]
    public byte familyKind;
    
    [FieldOffset(0)]
    public _text_e__Struct text;
    
    [FieldOffset(0)]
    public _script_e__Struct script;
    
    [FieldOffset(0)]
    public _decorative_e__Struct decorative;
    
    [FieldOffset(0)]
    public _symbol_e__Struct symbol;
}
