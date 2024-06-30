#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-displayconfig_set_target_persistence
public partial struct DISPLAYCONFIG_SET_TARGET_PERSISTENCE
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
        public uint value;
    }
    
    public DISPLAYCONFIG_DEVICE_INFO_HEADER header;
    public _Anonymous_e__Union Anonymous;
}
