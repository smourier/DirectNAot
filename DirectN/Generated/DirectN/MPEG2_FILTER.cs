#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mpeg2structs/ns-mpeg2structs-mpeg2_filter
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct MPEG2_FILTER
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
