#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/evntrace/ns-evntrace-event_trace_header
[StructLayout(LayoutKind.Sequential)]
public partial struct EVENT_TRACE_HEADER
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous1_e__Union
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct _Anonymous_e__Struct
        {
            public byte HeaderType;
            public byte MarkerFlags;
        }
        
        [FieldOffset(0)]
        public ushort FieldTypeFlags;
        
        [FieldOffset(0)]
        public _Anonymous_e__Struct Anonymous;
    }
    
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous2_e__Union
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct _Class_e__Struct
        {
            public byte Type;
            public byte Level;
            public ushort Version;
        }
        
        [FieldOffset(0)]
        public uint Version;
        
        [FieldOffset(0)]
        public _Class_e__Struct Class;
    }
    
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous3_e__Union
    {
        [FieldOffset(0)]
        public Guid Guid;
        
        [FieldOffset(0)]
        public ulong GuidPtr;
    }
    
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous4_e__Union
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct _Anonymous1_e__Struct
        {
            public uint KernelTime;
            public uint UserTime;
        }
        
        [StructLayout(LayoutKind.Sequential)]
        public struct _Anonymous2_e__Struct
        {
            public uint ClientContext;
            public uint Flags;
        }
        
        [FieldOffset(0)]
        public _Anonymous1_e__Struct Anonymous1;
        
        [FieldOffset(0)]
        public ulong ProcessorTime;
        
        [FieldOffset(0)]
        public _Anonymous2_e__Struct Anonymous2;
    }
    
    public ushort Size;
    public _Anonymous1_e__Union Anonymous1;
    public _Anonymous2_e__Union Anonymous2;
    public uint ThreadId;
    public uint ProcessId;
    public long TimeStamp;
    public _Anonymous3_e__Union Anonymous3;
    public _Anonymous4_e__Union Anonymous4;
}
