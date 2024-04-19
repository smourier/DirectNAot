namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSM_BDA_PIN_PAIR
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous1_e__Union
    {
        [FieldOffset(0)]
        public uint InputPinId;
        
        [FieldOffset(0)]
        public uint InputPinType;
    }
    
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous2_e__Union
    {
        [FieldOffset(0)]
        public uint OutputPinId;
        
        [FieldOffset(0)]
        public uint OutputPinType;
    }
    
    public KSIDENTIFIER Method;
    public _Anonymous1_e__Union Anonymous1;
    public _Anonymous2_e__Union Anonymous2;
}
