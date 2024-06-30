#nullable enable
namespace DirectN;

public partial struct DMUS_PORTPARAMS8
{
    public uint dwSize;
    public uint dwValidParams;
    public uint dwVoices;
    public uint dwChannelGroups;
    public uint dwAudioChannels;
    public uint dwSampleRate;
    public uint dwEffectFlags;
    public BOOL fShare;
    public uint dwFeatures;
}
