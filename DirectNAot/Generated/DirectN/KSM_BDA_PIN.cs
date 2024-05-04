#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSM_BDA_PIN
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public uint PinId;
        
        [FieldOffset(0)]
        public uint PinType;
    }
    
    public KSIDENTIFIER Method;
    public _Anonymous_e__Union Anonymous;
    public uint Reserved;
}
