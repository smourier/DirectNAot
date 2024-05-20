#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSEVENTDATA
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct _EventHandle_e__Struct
        {
            public HANDLE Event;
            public InlineArrayUIntPtr_2 Reserved;
        }
        
        [StructLayout(LayoutKind.Sequential)]
        public struct _SemaphoreHandle_e__Struct
        {
            public HANDLE Semaphore;
            public uint Reserved;
            public int Adjustment;
        }
        
        [StructLayout(LayoutKind.Sequential)]
        public struct _Alignment_e__Struct
        {
            public nint Unused;
            public InlineArrayIntPtr_2 Alignment;
        }
        
        [FieldOffset(0)]
        public _EventHandle_e__Struct EventHandle;
        
        [FieldOffset(0)]
        public _SemaphoreHandle_e__Struct SemaphoreHandle;
        
        [FieldOffset(0)]
        public _Alignment_e__Struct Alignment;
    }
    
    public uint NotificationType;
    public _Anonymous_e__Union Anonymous;
}
