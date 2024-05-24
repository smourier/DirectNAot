#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xaudio2/ns-xaudio2-xaudio2_voice_sends
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct XAUDIO2_VOICE_SENDS
{
    public uint SendCount;
    public nint pSends;
}
