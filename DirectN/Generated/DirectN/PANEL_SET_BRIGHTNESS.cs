#nullable enable
namespace DirectN;

public partial struct PANEL_SET_BRIGHTNESS
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        public struct _Anonymous_e__Struct
        {
            public uint Millinits;
            public uint TransitionTimeInMs;
            public PANEL_BRIGHTNESS_SENSOR_DATA SensorData;
        }
        
        [FieldOffset(0)]
        public byte Level;
        
        [FieldOffset(0)]
        public _Anonymous_e__Struct Anonymous;
    }
    
    public BRIGHTNESS_INTERFACE_VERSION Version;
    public _Anonymous_e__Union Anonymous;
}
