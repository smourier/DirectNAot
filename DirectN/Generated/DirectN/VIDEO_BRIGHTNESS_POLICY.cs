#nullable enable
namespace DirectN;

public partial struct VIDEO_BRIGHTNESS_POLICY
{
    [InlineArray(InlineArray_Anonymous_e__Struct_1.Length)]
    public partial struct InlineArray_Anonymous_e__Struct_1
    {
        public const int Length = 1;
        
        public _Anonymous_e__Struct Data;
    }
    
    public struct _Anonymous_e__Struct
    {
        public byte BatteryLevel;
        public byte Brightness;
    }
    
    public BOOLEAN DefaultToBiosPolicy;
    public byte LevelCount;
    public InlineArray_Anonymous_e__Struct_1 Level; // variable-length array placeholder
}
