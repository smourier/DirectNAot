#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xaudio2/ns-xaudio2-xaudio2_effect_descriptor
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct XAUDIO2_EFFECT_DESCRIPTOR
{
    public nint pEffect;
    public BOOL InitialState;
    public uint OutputChannels;
}
