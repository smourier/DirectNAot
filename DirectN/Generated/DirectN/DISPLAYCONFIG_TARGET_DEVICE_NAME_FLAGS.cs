#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-displayconfig_target_device_name_flags
[StructLayout(LayoutKind.Sequential)]
public partial struct DISPLAYCONFIG_TARGET_DEVICE_NAME_FLAGS
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct _Anonymous_e__Struct
        {
            public uint _bitfield;
        }
        
        [FieldOffset(0)]
        public _Anonymous_e__Struct Anonymous;
        
        [FieldOffset(0)]
        public uint value;
    }
    
    public _Anonymous_e__Union Anonymous;
}
