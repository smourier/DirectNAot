#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mpeg2structs/ns-mpeg2structs-dsmcc_section
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct DSMCC_SECTION
{
    [StructLayout(LayoutKind.Explicit, Pack = 1)]
    public struct _Header_e__Union
    {
        [FieldOffset(0)]
        public MPEG_HEADER_BITS_MIDL S;
        
        [FieldOffset(0)]
        public ushort W;
    }
    
    [StructLayout(LayoutKind.Explicit)]
    public struct _Version_e__Union
    {
        [FieldOffset(0)]
        public MPEG_HEADER_VERSION_BITS_MIDL S;
        
        [FieldOffset(0)]
        public byte B;
    }
    
    public byte TableId;
    public _Header_e__Union Header;
    public ushort TableIdExtension;
    public _Version_e__Union Version;
    public byte SectionNumber;
    public byte LastSectionNumber;
    public byte ProtocolDiscriminator;
    public byte DsmccType;
    public ushort MessageId;
    public uint TransactionId;
    public byte Reserved;
    public byte AdaptationLength;
    public ushort MessageLength;
    public InlineArrayByte_1 RemainingData; // variable-length array placeholder
}
