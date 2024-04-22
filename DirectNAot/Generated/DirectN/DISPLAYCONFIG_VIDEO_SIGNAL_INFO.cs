namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-displayconfig_video_signal_info
[StructLayout(LayoutKind.Sequential)]
public partial struct DISPLAYCONFIG_VIDEO_SIGNAL_INFO
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct _AdditionalSignalInfo_e__Struct
        {
            public uint _bitfield;
        }
        
        [FieldOffset(0)]
        public _AdditionalSignalInfo_e__Struct AdditionalSignalInfo;
        
        [FieldOffset(0)]
        public uint videoStandard;
    }
    
    public ulong pixelRate;
    public DISPLAYCONFIG_RATIONAL hSyncFreq;
    public DISPLAYCONFIG_RATIONAL vSyncFreq;
    public DISPLAYCONFIG_2DREGION activeSize;
    public DISPLAYCONFIG_2DREGION totalSize;
    public _Anonymous_e__Union Anonymous;
    public DISPLAYCONFIG_SCANLINE_ORDERING scanLineOrdering;
}
