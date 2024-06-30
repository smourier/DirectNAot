#nullable enable
namespace DirectN;

public partial struct KSAUDIO_PACKETSIZE_CONSTRAINTS
{
    public uint MinPacketPeriodInHns;
    public uint PacketSizeFileAlignment;
    public uint Reserved;
    public uint NumProcessingModeConstraints;
    public InlineArrayKSAUDIO_PACKETSIZE_PROCESSINGMODE_CONSTRAINT_1 ProcessingModeConstraints; // variable-length array placeholder
}
