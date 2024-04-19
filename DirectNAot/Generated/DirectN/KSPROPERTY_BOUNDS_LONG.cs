namespace DirectN;

[StructLayout(LayoutKind.Explicit)]
public partial struct KSPROPERTY_BOUNDS_LONG
{
    [StructLayout(LayoutKind.Sequential)]
    public struct _Anonymous1_e__Struct
    {
        public int SignedMinimum;
        public int SignedMaximum;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct _Anonymous2_e__Struct
    {
        public uint UnsignedMinimum;
        public uint UnsignedMaximum;
    }
    
    [FieldOffset(0)]
    public _Anonymous1_e__Struct Anonymous1;
    
    [FieldOffset(0)]
    public _Anonymous2_e__Struct Anonymous2;
}
