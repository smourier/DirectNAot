#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/minwinbase/ns-minwinbase-overlapped
[StructLayout(LayoutKind.Sequential)]
public partial struct OVERLAPPED
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct _Anonymous_e__Struct
        {
            public uint Offset;
            public uint OffsetHigh;
        }
        
        [FieldOffset(0)]
        public _Anonymous_e__Struct Anonymous;
        
        [FieldOffset(0)]
        public nint Pointer;
    }
    
    public nuint Internal;
    public nuint InternalHigh;
    public _Anonymous_e__Union Anonymous;
    public HANDLE hEvent;
}
