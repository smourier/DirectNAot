#nullable enable
namespace DirectN;

public partial struct TRANSPORT_PROPERTIES
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Fields_e__Union
    {
        public struct _Others
        {
            public long _bitfield;
        }
        
        [FieldOffset(0)]
        public _Others Others;
        
        [FieldOffset(0)]
        public long Value;
    }
    
    public uint PID;
    public long PCR;
    public _Fields_e__Union Fields;
}
