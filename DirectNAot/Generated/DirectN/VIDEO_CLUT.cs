#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct VIDEO_CLUT
{
    [InlineArray(1)]
    public partial struct InlineArray_Anonymous_e__Union1
    {
        public static int Length => 1;
        
        public _Anonymous_e__Union Data;
    }
    
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public VIDEO_CLUTDATA RgbArray;
        
        [FieldOffset(0)]
        public uint RgbLong;
    }
    
    public ushort NumEntries;
    public ushort FirstEntry;
    public InlineArray_Anonymous_e__Union1 LookupTable; // variable-length array placeholder
}
