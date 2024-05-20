#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xaudio2/ns-xaudio2-xaudio2_voice_state
[StructLayout(LayoutKind.Sequential)]
public partial struct XAUDIO2_VOICE_STATE
{
    public nint pCurrentBufferContext;
    public uint BuffersQueued;
    public ulong SamplesPlayed;
}
