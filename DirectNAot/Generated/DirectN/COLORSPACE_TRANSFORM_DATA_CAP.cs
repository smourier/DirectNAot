#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct COLORSPACE_TRANSFORM_DATA_CAP
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct _Anonymous1_e__Struct
        {
            public uint _bitfield;
        }
        
        [StructLayout(LayoutKind.Sequential)]
        public struct _Anonymous2_e__Struct
        {
            public uint _bitfield;
        }
        
        [FieldOffset(0)]
        public _Anonymous1_e__Struct Anonymous1;
        
        [FieldOffset(0)]
        public _Anonymous2_e__Struct Anonymous2;
        
        [FieldOffset(0)]
        public uint Value;
    }
    
    public COLORSPACE_TRANSFORM_DATA_TYPE DataType;
    public _Anonymous_e__Union Anonymous;
    public float NumericRangeMin;
    public float NumericRangeMax;
}
