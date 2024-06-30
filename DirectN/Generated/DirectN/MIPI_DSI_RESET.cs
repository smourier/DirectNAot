#nullable enable
namespace DirectN;

public partial struct MIPI_DSI_RESET
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        public struct _Anonymous_e__Struct
        {
            public uint _bitfield;
        }
        
        [FieldOffset(0)]
        public _Anonymous_e__Struct Anonymous;
        
        [FieldOffset(0)]
        public uint Results;
    }
    
    public uint Flags;
    public _Anonymous_e__Union Anonymous;
}
