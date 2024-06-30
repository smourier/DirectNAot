#nullable enable
namespace DirectN;

public partial struct KSP_PIN
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public uint Reserved;
        
        [FieldOffset(0)]
        public uint Flags;
    }
    
    public KSIDENTIFIER Property;
    public uint PinId;
    public _Anonymous_e__Union Anonymous;
}
