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
    
    [MarshalAs(UnmanagedType.U4)]
    public bool AutoFocusLock;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool AutoExposureLock;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool AutoWhitebalanceLock;
    public _Anonymous_e__Union Anonymous;
}
