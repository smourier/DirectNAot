namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xaudio2/ns-xaudio2-xaudio2_effect_chain
[StructLayout(LayoutKind.Sequential)]
public partial struct XAUDIO2_EFFECT_CHAIN
{
    public uint EffectCount;
    public nint pEffectDescriptors;
}
