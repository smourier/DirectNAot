#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSPROPERTY_CAMERACONTROL_REGION_OF_INTEREST_S
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public uint Capabilities;
        
        [FieldOffset(0)]
        public uint Configuration;
    }
    
    public RECT FocusRect;
    public BOOL AutoFocusLock;
    public BOOL AutoExposureLock;
    public BOOL AutoWhitebalanceLock;
    public _Anonymous_e__Union Anonymous;
}
