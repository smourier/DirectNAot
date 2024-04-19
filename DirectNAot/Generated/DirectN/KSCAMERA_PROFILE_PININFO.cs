namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSCAMERA_PROFILE_PININFO
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct _Anonymous_e__Struct
        {
            public ushort PinIndex;
            public ushort ProfileSensorType;
        }
        
        [FieldOffset(0)]
        public _Anonymous_e__Struct Anonymous;
        
        [FieldOffset(0)]
        public uint Reserved;
    }
    
    public Guid PinCategory;
    public _Anonymous_e__Union Anonymous;
    public uint MediaInfoCount;
    public nint MediaInfos;
}
