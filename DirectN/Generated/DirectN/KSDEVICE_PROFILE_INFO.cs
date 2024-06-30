#nullable enable
namespace DirectN;

public partial struct KSDEVICE_PROFILE_INFO
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        public struct _Camera_e__Struct
        {
            public KSCAMERA_PROFILE_INFO Info;
            public uint Reserved;
            public uint ConcurrencyCount;
            public nint Concurrency;
        }
        
        [FieldOffset(0)]
        public _Camera_e__Struct Camera;
    }
    
    public uint Type;
    public uint Size;
    public _Anonymous_e__Union Anonymous;
}
