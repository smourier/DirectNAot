#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DS3DVECTOR
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
    
    public _Anonymous1_e__Union Anonymous1;
    public _Anonymous2_e__Union Anonymous2;
    public _Anonymous3_e__Union Anonymous3;
}
