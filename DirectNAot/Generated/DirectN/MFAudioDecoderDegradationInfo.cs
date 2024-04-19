namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct MFAudioDecoderDegradationInfo
{
    public MFT_AUDIO_DECODER_DEGRADATION_REASON eDegradationReason;
    public MFT_AUDIO_DECODER_DEGRADATION_TYPE eType;
}
