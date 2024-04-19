namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mpeg2structs/ns-mpeg2structs-mpeg2_filter
[StructLayout(LayoutKind.Sequential)]
public partial struct MPEG2_FILTER
{
    public byte bVersionNumber;
    public ushort wFilterSize;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool fUseRawFilteringBits;
    public InlineArrayByte16 Filter;
    public InlineArrayByte16 Mask;
    
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
