#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct PANEL_GET_BRIGHTNESS
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct _Anonymous_e__Struct
        {
            public uint CurrentInMillinits;
            public uint TargetInMillinits;
        }
        
        [FieldOffset(0)]
        public byte Level;
        
        [FieldOffset(0)]
        public _Anonymous_e__Struct Anonymous;
    }
    
    public BRIGHTNESS_INTERFACE_VERSION Version;
    public _Anonymous_e__Union Anonymous;
}
