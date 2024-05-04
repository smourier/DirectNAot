#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSAUDIO_PACKETSIZE_CONSTRAINTS
{
    public uint MinPacketPeriodInHns;
    public uint PacketSizeFileAlignment;
    public uint Reserved;
    public uint NumProcessingModeConstraints;
    public InlineArrayKSAUDIO_PACKETSIZE_PROCESSINGMODE_CONSTRAINT1 ProcessingModeConstraints; // variable-length array placeholder
}
