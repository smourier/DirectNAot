namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct PrintPropertyValue
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _value_e__Union
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct _propertyBlob_e__Struct
        {
            public uint cbBuf;
            public nint pBuf;
        }
        
        [FieldOffset(0)]
        public byte propertyByte;
        
        [FieldOffset(0)]
        public PWSTR propertyString;
        
        [FieldOffset(0)]
        public int propertyInt32;
        
        [FieldOffset(0)]
        public long propertyInt64;
        
        [FieldOffset(0)]
        public _propertyBlob_e__Struct propertyBlob;
    }
    
    public EPrintPropertyType ePropertyType;
    public _value_e__Union value;
}
