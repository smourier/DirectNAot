namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct TRANSDATA
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _uCode_e__Union
    {
        [FieldOffset(0)]
        public short sCode;
        
        [FieldOffset(0)]
        public byte ubCode;
        
        [FieldOffset(0)]
        public InlineArrayByte2 ubPairs;
    }
    
    public byte ubCodePageID;
    public byte ubType;
    public _uCode_e__Union uCode;
}
