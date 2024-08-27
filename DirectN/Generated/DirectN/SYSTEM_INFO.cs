#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/sysinfoapi/ns-sysinfoapi-system_info
public partial struct SYSTEM_INFO
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        public struct _Anonymous_e__Struct
        {
            public PROCESSOR_ARCHITECTURE wProcessorArchitecture;
            public ushort wReserved;
        }
        
        [FieldOffset(0)]
        public uint dwOemId;
        
        [FieldOffset(0)]
        public _Anonymous_e__Struct Anonymous;
    }
    
    public _Anonymous_e__Union Anonymous;
    public uint dwPageSize;
    public nint lpMinimumApplicationAddress;
    public nint lpMaximumApplicationAddress;
    public nuint dwActiveProcessorMask;
    public uint dwNumberOfProcessors;
    public uint dwProcessorType;
    public uint dwAllocationGranularity;
    public ushort wProcessorLevel;
    public ushort wProcessorRevision;
}
