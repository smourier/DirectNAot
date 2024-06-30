#nullable enable
namespace DirectN;

public partial struct KSIDENTIFIER
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        public struct _Anonymous_e__Struct
        {
            public Guid Set;
            public uint Id;
            public uint Flags;
        }
        
        [FieldOffset(0)]
        public _Anonymous_e__Struct Anonymous;
        
        [FieldOffset(0)]
        public long Alignment;
    }
    
    public _Anonymous_e__Union Anonymous;
}
