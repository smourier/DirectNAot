#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mpeg2structs/ns-mpeg2structs-mpeg_packet_list
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct MPEG_PACKET_LIST
{
    public ushort wPacketCount;
    public InlineArrayMPEG_RQST_PACKET_1 PacketList; // variable-length array placeholder
}
