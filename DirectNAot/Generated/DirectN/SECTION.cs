#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mpeg2structs/ns-mpeg2structs-section
[StructLayout(LayoutKind.Sequential)]
public partial struct SECTION
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Header_e__Union
    {
        [FieldOffset(0)]
        public MPEG_HEADER_BITS_MIDL S;
        
        [FieldOffset(0)]
        public ushort W;
    }
    
    public byte TableId;
    public _Header_e__Union Header;
    public InlineArrayByte1 SectionData; // variable-length array placeholder
}
