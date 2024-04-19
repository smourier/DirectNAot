namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct ChannelInfo
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct _DVB_e__Struct
        {
            public int lONID;
            public int lTSID;
            public int lSID;
        }
        
        [StructLayout(LayoutKind.Sequential)]
        public struct _DC_e__Struct
        {
            public int lProgNumber;
        }
        
        [StructLayout(LayoutKind.Sequential)]
        public struct _ATSC_e__Struct
        {
            public int lProgNumber;
        }
        
        [FieldOffset(0)]
        public _DVB_e__Struct DVB;
        
        [FieldOffset(0)]
        public _DC_e__Struct DC;
        
        [FieldOffset(0)]
        public _ATSC_e__Struct ATSC;
    }
    
    public int lFrequency;
    public _Anonymous_e__Union Anonymous;
}
