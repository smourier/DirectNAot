#nullable enable
namespace DirectN;

public partial struct D3D12_CLEAR_DATA
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public InlineArraySingle_4 Floats;
        
        [FieldOffset(0)]
        public InlineArrayUInt32_4 Uints;
        
        [FieldOffset(0)]
        public InlineArrayInt32_4 Sints;
        
        [FieldOffset(0)]
        public InlineArrayByte_16 Bytes;
    }
    
    public _Anonymous_e__Union Anonymous;
}
