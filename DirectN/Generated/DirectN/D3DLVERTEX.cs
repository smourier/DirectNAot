#nullable enable
namespace DirectN;

public partial struct D3DLVERTEX
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
        public uint color;
        
        [FieldOffset(0)]
        public uint dcColor;
    }
    
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous5_e__Union
    {
        [FieldOffset(0)]
        public uint specular;
        
        [FieldOffset(0)]
        public uint dcSpecular;
    }
    
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous6_e__Union
    {
        [FieldOffset(0)]
        public float tu;
        
        [FieldOffset(0)]
        public float dvTU;
    }
    
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous7_e__Union
    {
        [FieldOffset(0)]
        public float tv;
        
        [FieldOffset(0)]
        public float dvTV;
    }
    
    public _Anonymous1_e__Union Anonymous1;
    public _Anonymous2_e__Union Anonymous2;
    public _Anonymous3_e__Union Anonymous3;
    public uint dwReserved;
    public _Anonymous4_e__Union Anonymous4;
    public _Anonymous5_e__Union Anonymous5;
    public _Anonymous6_e__Union Anonymous6;
    public _Anonymous7_e__Union Anonymous7;
}
