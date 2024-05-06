#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mpeg2structs/ns-mpeg2structs-long_section
[StructLayout(LayoutKind.Sequential)]
public partial struct LONG_SECTION
{
    [StructLayout(LayoutKind.Explicit)]
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
    public InlineArrayByte_1 RemainingData; // variable-length array placeholder
}
