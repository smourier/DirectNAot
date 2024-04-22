namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-displayconfig_support_virtual_resolution
[StructLayout(LayoutKind.Sequential)]
public partial struct DISPLAYCONFIG_SUPPORT_VIRTUAL_RESOLUTION
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
    
    public DISPLAYCONFIG_DEVICE_INFO_HEADER header;
    public _Anonymous_e__Union Anonymous;
}
