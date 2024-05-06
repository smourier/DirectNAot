#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DMUS_PORTCAPS
{
    public uint dwSize;
    public uint dwFlags;
    public Guid guidPort;
    public uint dwClass;
    public uint dwType;
    public uint dwMemorySize;
    public uint dwMaxChannelGroups;
    public uint dwMaxVoices;
    public uint dwMaxAudioChannels;
    public uint dwEffectFlags;
    public InlineArraySystemChar_128 wszDescription;
}
