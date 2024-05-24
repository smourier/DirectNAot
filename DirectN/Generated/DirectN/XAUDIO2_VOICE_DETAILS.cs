#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xaudio2/ns-xaudio2-xaudio2_voice_details
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct XAUDIO2_VOICE_DETAILS
{
    public uint CreationFlags;
    public uint ActiveFlags;
    public uint InputChannels;
    public uint InputSampleRate;
}
