#nullable enable
namespace DirectN;

public partial struct PANEL_QUERY_BRIGHTNESS_RANGES
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public BRIGHTNESS_LEVEL BrightnessLevel;
        
        [FieldOffset(0)]
        public BRIGHTNESS_NIT_RANGES NitRanges;
    }
    
    public BRIGHTNESS_INTERFACE_VERSION Version;
    public _Anonymous_e__Union Anonymous;
}
