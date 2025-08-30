#nullable enable
namespace DirectN;

public partial struct KSCAMERA_EXTENDEDPROP_VALUE
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Value_e__Union
    {
        [FieldOffset(0)]
        public double dbl;
        
        [FieldOffset(0)]
        public ulong ull;
        
        [FieldOffset(0)]
        public uint ul;
        
        [FieldOffset(0)]
        public ulong ratio;
        
        [FieldOffset(0)]
        public int l;
        
        [FieldOffset(0)]
        public long ll;
    }
    
    public _Value_e__Union Value;
}
