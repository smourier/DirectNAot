namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mpeg2structs/ns-mpeg2structs-dsmcc_element
[StructLayout(LayoutKind.Sequential)]
public partial struct DSMCC_ELEMENT
{
    public ushort pid;
    public byte bComponentTag;
    public uint dwCarouselId;
    public uint dwTransactionId;
    public nint pNext;
}
