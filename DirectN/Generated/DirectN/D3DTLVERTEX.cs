#nullable enable
namespace DirectN;

public partial struct D3DTLVERTEX
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous1_e__Union
    {
        [FieldOffset(0)]
        public float sx;
        
        [FieldOffset(0)]
        public float dvSX;
    }
    
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous2_e__Union
    {
        [FieldOffset(0)]
        public float sy;
        
        [FieldOffset(0)]
        public float dvSY;
    }
    
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous3_e__Union
    {
        [FieldOffset(0)]
        public float sz;
        
        [FieldOffset(0)]
        public float dvSZ;
    }
    
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous4_e__Union
    {
        [FieldOffset(0)]
        public float rhw;
        
        [FieldOffset(0)]
        public float dvRHW;
    }
    
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous5_e__Union
    {
        [FieldOffset(0)]
        public uint color;
        
        [FieldOffset(0)]
        public uint dcColor;
    }
    
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous6_e__Union
    {
        [FieldOffset(0)]
        public uint specular;
        
        [FieldOffset(0)]
        public uint dcSpecular;
    }
    
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous7_e__Union
    {
        [FieldOffset(0)]
        public float tu;
        
        [FieldOffset(0)]
        public float dvTU;
    }
    
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous8_e__Union
    {
        [FieldOffset(0)]
        public float tv;
        
        [FieldOffset(0)]
        public float dvTV;
    }
    
    public _Anonymous1_e__Union Anonymous1;
    public _Anonymous2_e__Union Anonymous2;
    public _Anonymous3_e__Union Anonymous3;
    public _Anonymous4_e__Union Anonymous4;
    public _Anonymous5_e__Union Anonymous5;
    public _Anonymous6_e__Union Anonymous6;
    public _Anonymous7_e__Union Anonymous7;
    public _Anonymous8_e__Union Anonymous8;
}
