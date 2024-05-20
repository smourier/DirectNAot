#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSAUDIO_PACKETSIZE_PROCESSINGMODE_CONSTRAINT
{
    public Guid ProcessingMode;
    public uint SamplesPerProcessingPacket;
    public uint ProcessingPacketDurationInHns;
}
