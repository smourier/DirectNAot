namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSAUDIOMODULE_NOTIFICATION
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct _ProviderId_e__Struct
        {
            public Guid DeviceId;
            public Guid ClassId;
            public uint InstanceId;
            public uint Reserved;
        }
        
        [FieldOffset(0)]
        public _ProviderId_e__Struct ProviderId;
        
        [FieldOffset(0)]
        public long Alignment;
    }
    
    public _Anonymous_e__Union Anonymous;
}
