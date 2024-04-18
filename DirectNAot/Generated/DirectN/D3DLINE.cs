namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct D3DLINE
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous1_e__Union
    {
        [FieldOffset(0)]
        public ushort v1;
        
        [FieldOffset(0)]
        public ushort wV1;
    }
    
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous2_e__Union
    {
        [FieldOffset(0)]
        public ushort v2;
        
        [FieldOffset(0)]
        public ushort wV2;
    }
    
    public _Anonymous1_e__Union Anonymous1;
    public _Anonymous2_e__Union Anonymous2;
}
