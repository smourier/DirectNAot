#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-displayconfig_path_target_info
public partial struct DISPLAYCONFIG_PATH_TARGET_INFO
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        public struct _Anonymous_e__Struct
        {
            public uint _bitfield;
        }
        
        [FieldOffset(0)]
        public uint modeInfoIdx;
        
        [FieldOffset(0)]
        public _Anonymous_e__Struct Anonymous;
    }
    
    public LUID adapterId;
    public uint id;
    public _Anonymous_e__Union Anonymous;
    public DISPLAYCONFIG_VIDEO_OUTPUT_TECHNOLOGY outputTechnology;
    public DISPLAYCONFIG_ROTATION rotation;
    public DISPLAYCONFIG_SCALING scaling;
    public DISPLAYCONFIG_RATIONAL refreshRate;
    public DISPLAYCONFIG_SCANLINE_ORDERING scanLineOrdering;
    public BOOL targetAvailable;
    public uint statusFlags;
}
