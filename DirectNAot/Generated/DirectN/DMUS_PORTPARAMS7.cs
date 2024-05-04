#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DMUS_PORTPARAMS7
{
    public uint dwSize;
    public uint dwValidParams;
    public uint dwVoices;
    public uint dwChannelGroups;
    public uint dwAudioChannels;
    public uint dwSampleRate;
    public uint dwEffectFlags;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool fShare;
}
