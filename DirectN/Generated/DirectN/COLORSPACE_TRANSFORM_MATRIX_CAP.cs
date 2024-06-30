#nullable enable
namespace DirectN;

public partial struct COLORSPACE_TRANSFORM_MATRIX_CAP
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        public struct _Anonymous_e__Struct
        {
            public uint _bitfield;
        }
        
        [FieldOffset(0)]
        public _Anonymous_e__Struct Anonymous;
        
        [FieldOffset(0)]
        public uint Value;
    }
    
    public _Anonymous_e__Union Anonymous;
    public COLORSPACE_TRANSFORM_DATA_CAP DataCap;
}
