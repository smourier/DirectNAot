#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-displayconfig_mode_info
[StructLayout(LayoutKind.Sequential)]
public partial struct DISPLAYCONFIG_MODE_INFO
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public DISPLAYCONFIG_TARGET_MODE targetMode;
        
        [FieldOffset(0)]
        public DISPLAYCONFIG_SOURCE_MODE sourceMode;
        
        [FieldOffset(0)]
        public DISPLAYCONFIG_DESKTOP_IMAGE_INFO desktopImageInfo;
    }
    
    public DISPLAYCONFIG_MODE_INFO_TYPE infoType;
    public uint id;
    public LUID adapterId;
    public _Anonymous_e__Union Anonymous;
}
