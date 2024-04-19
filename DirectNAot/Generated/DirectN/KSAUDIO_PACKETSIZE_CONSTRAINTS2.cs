namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSAUDIO_PACKETSIZE_CONSTRAINTS2
{
    public uint MinPacketPeriodInHns;
    public uint PacketSizeFileAlignment;
    public uint MaxPacketSizeInBytes;
    public uint NumProcessingModeConstraints;
    public InlineArrayKSAUDIO_PACKETSIZE_PROCESSINGMODE_CONSTRAINT1 ProcessingModeConstraints; // variable-length array placeholder
}
