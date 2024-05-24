#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mpeg2structs/ns-mpeg2structs-mpeg2_filter2
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct MPEG2_FILTER2
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct _Anonymous_e__Struct
        {
            public byte bVersionNumber;
            public ushort wFilterSize;
            
            [MarshalAs(UnmanagedType.U4)]
            public bool fUseRawFilteringBits;
            public InlineArrayByte_16 Filter;
            public InlineArrayByte_16 Mask;
            
            [MarshalAs(UnmanagedType.U4)]
            public bool fSpecifyTableIdExtension;
            public ushort TableIdExtension;
            
            [MarshalAs(UnmanagedType.U4)]
            public bool fSpecifyVersion;
            public byte Version;
            
            [MarshalAs(UnmanagedType.U4)]
            public bool fSpecifySectionNumber;
            public byte SectionNumber;
            
            [MarshalAs(UnmanagedType.U4)]
            public bool fSpecifyCurrentNext;
            
            [MarshalAs(UnmanagedType.U4)]
            public bool fNext;
            
            [MarshalAs(UnmanagedType.U4)]
            public bool fSpecifyDsmccOptions;
            public DSMCC_FILTER_OPTIONS Dsmcc;
            
            [MarshalAs(UnmanagedType.U4)]
            public bool fSpecifyAtscOptions;
            public ATSC_FILTER_OPTIONS Atsc;
        }
        
        [FieldOffset(0)]
        public _Anonymous_e__Struct Anonymous;
        
        [FieldOffset(0)]
        public InlineArrayByte_124 bVersion1Bytes;
    }
    
    public _Anonymous_e__Union Anonymous;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool fSpecifyDvbEitOptions;
    public DVB_EIT_FILTER_OPTIONS DvbEit;
}
