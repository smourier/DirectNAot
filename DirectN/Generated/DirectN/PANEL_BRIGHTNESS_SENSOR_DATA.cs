#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct PANEL_BRIGHTNESS_SENSOR_DATA
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
        public uint Value;
    }
    
    public _Anonymous_e__Union Anonymous;
    public float AlsReading;
    public CHROMATICITY_COORDINATE ChromaticityCoordinate;
    public float ColorTemperature;
}
