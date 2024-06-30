#nullable enable
namespace DirectN;

public partial struct D3DVERTEX
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous1_e__Union
    {
        [FieldOffset(0)]
        public float x;
        
        [FieldOffset(0)]
        public float dvX;
    }
    
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous2_e__Union
    {
        [FieldOffset(0)]
        public float y;
        
        [FieldOffset(0)]
        public float dvY;
    }
    
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous3_e__Union
    {
        [FieldOffset(0)]
        public float z;
        
        [FieldOffset(0)]
        public float dvZ;
    }
    
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous4_e__Union
    {
        [FieldOffset(0)]
        public float nx;
        
        [FieldOffset(0)]
        public float dvNX;
    }
    
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous5_e__Union
    {
        [FieldOffset(0)]
        public float ny;
        
        [FieldOffset(0)]
        public float dvNY;
    }
    
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous6_e__Union
    {
        [FieldOffset(0)]
        public float nz;
        
        [FieldOffset(0)]
        public float dvNZ;
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
