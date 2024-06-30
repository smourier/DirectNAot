#nullable enable
namespace DirectN;

public partial struct MIPI_DSI_TRANSMISSION
{
    public struct _Anonymous_e__Struct
    {
        public ushort _bitfield;
    }
    
    public uint TotalBufferSize;
    public byte PacketCount;
    public byte FailedPacket;
    public _Anonymous_e__Struct Anonymous;
    public ushort ReadWordCount;
    public ushort FinalCommandExtraPayload;
    public ushort MipiErrors;
    public ushort HostErrors;
    public InlineArrayMIPI_DSI_PACKET_1 Packets; // variable-length array placeholder
}
