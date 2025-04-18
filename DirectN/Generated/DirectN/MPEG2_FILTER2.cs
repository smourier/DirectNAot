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
            public BOOL fUseRawFilteringBits;
            public InlineArrayByte_16 Filter;
            public InlineArrayByte_16 Mask;
            public BOOL fSpecifyTableIdExtension;
            public ushort TableIdExtension;
            public BOOL fSpecifyVersion;
            public byte Version;
            public BOOL fSpecifySectionNumber;
            public byte SectionNumber;
            public BOOL fSpecifyCurrentNext;
            public BOOL fNext;
            public BOOL fSpecifyDsmccOptions;
            public DSMCC_FILTER_OPTIONS Dsmcc;
            public BOOL fSpecifyAtscOptions;
            public ATSC_FILTER_OPTIONS Atsc;
        }
        
        [FieldOffset(0)]
        public _Anonymous_e__Struct Anonymous;
        
        [FieldOffset(0)]
        public InlineArrayByte_124 bVersion1Bytes;
    }
    
    public _Anonymous_e__Union Anonymous;
    public BOOL fSpecifyDvbEitOptions;
    public DVB_EIT_FILTER_OPTIONS DvbEit;
}
