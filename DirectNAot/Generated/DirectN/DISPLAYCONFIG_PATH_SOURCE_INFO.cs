namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-displayconfig_path_source_info
[StructLayout(LayoutKind.Sequential)]
public partial struct DISPLAYCONFIG_PATH_SOURCE_INFO
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [StructLayout(LayoutKind.Sequential)]
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
    public uint statusFlags;
}
