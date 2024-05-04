#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct D3DHVERTEX
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous1_e__Union
    {
        [FieldOffset(0)]
        public float hx;
        
        [FieldOffset(0)]
        public float dvHX;
    }
    
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous2_e__Union
    {
        [FieldOffset(0)]
        public float hy;
        
        [FieldOffset(0)]
        public float dvHY;
    }
    
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous3_e__Union
    {
        [FieldOffset(0)]
        public float hz;
        
        [FieldOffset(0)]
        public float dvHZ;
    }
    
    public uint dwFlags;
    public _Anonymous1_e__Union Anonymous1;
    public _Anonymous2_e__Union Anonymous2;
    public _Anonymous3_e__Union Anonymous3;
}
