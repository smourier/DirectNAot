namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSPROPERTY_EXTDEVICE_S
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _u_e__Union
    {
        [FieldOffset(0)]
        public DEVCAPS Capabilities;
        
        [FieldOffset(0)]
        public uint DevPort;
        
        [FieldOffset(0)]
        public uint PowerState;
        
        [FieldOffset(0)]
        public InlineArraySystemChar260 pawchString;
        
        [FieldOffset(0)]
        public InlineArrayUInt322 NodeUniqueID;
    }
    
    public KSIDENTIFIER Property;
    public _u_e__Union u;
}
