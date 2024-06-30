#nullable enable
namespace DirectN;

public partial struct ChannelInfo
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        public struct _DVB_e__Struct
        {
            public int lONID;
            public int lTSID;
            public int lSID;
        }
        
        public struct _DC_e__Struct
        {
            public int lProgNumber;
        }
        
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
