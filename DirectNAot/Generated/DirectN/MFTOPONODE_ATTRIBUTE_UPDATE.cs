namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/ns-mfidl-mftoponode_attribute_update
[StructLayout(LayoutKind.Sequential)]
public partial struct MFTOPONODE_ATTRIBUTE_UPDATE
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public uint u32;
        
        [FieldOffset(0)]
        public ulong u64;
        
        [FieldOffset(0)]
        public double d;
    }
    
    public ulong NodeId;
    public Guid guidAttributeKey;
    public MF_ATTRIBUTE_TYPE attrType;
    public _Anonymous_e__Union Anonymous;
}
