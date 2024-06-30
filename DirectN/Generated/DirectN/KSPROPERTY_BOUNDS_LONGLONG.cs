#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Explicit)]
public partial struct KSPROPERTY_BOUNDS_LONGLONG
{
    public struct _Anonymous1_e__Struct
    {
        public long SignedMinimum;
        public long SignedMaximum;
    }
    
    public struct _Anonymous2_e__Struct
    {
        public ulong UnsignedMinimum;
        public ulong UnsignedMaximum;
    }
    
    [FieldOffset(0)]
    public _Anonymous1_e__Struct Anonymous1;
    
    [FieldOffset(0)]
    public _Anonymous2_e__Struct Anonymous2;
}
