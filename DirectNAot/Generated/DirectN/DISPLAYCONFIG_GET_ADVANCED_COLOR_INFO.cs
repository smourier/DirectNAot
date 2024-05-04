#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DISPLAYCONFIG_GET_ADVANCED_COLOR_INFO
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
    public DISPLAYCONFIG_COLOR_ENCODING colorEncoding;
    public uint bitsPerColorChannel;
}
