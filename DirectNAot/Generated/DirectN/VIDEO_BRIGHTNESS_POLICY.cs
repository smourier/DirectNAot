#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct VIDEO_BRIGHTNESS_POLICY
{
    [InlineArray(1)]
    public partial struct InlineArray_Anonymous_e__Struct1
    {
        public _Anonymous_e__Struct Data;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct _Anonymous_e__Struct
    {
        public byte BatteryLevel;
        public byte Brightness;
    }
    
    public BOOLEAN DefaultToBiosPolicy;
    public byte LevelCount;
    public InlineArray_Anonymous_e__Struct1 Level; // variable-length array placeholder
}
